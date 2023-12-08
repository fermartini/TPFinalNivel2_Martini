using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class ArticuloDetalles : Form
    {
        private Articulo articulo = null;        
        private int detalle = 0;
        private OpenFileDialog archivo = null;
        //PARA DETALLE ARTICULOS PARA AGREGAR
        public ArticuloDetalles()
        {
            InitializeComponent();

        }
        //PARA DETALLE ARTICULOS PARA MODIFICAR
        public ArticuloDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            
        }
        //PARA DETALLE ARTICULOS PARA VISUALIZAR Y ELIMINAR
        public ArticuloDetalles(Articulo articulo, int detalle)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.detalle = detalle;
        }
        
       




        
        //CARGAMOS EL FORM CON DATOS ARTICULOS, MARCAS O CATEGORIA SEGUN EL BOTON QUE TOQEMOS
        private void ArticuloDetalles_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            txtMarca.DataSource = marcaNegocio.listar();
            txtMarca.ValueMember = "id";
            txtMarca.DisplayMember = "Descripcion";
            txtCategoria.DataSource = categoriaNegocio.listar();
            txtCategoria.ValueMember = "id";
            txtCategoria.DisplayMember = "Descripcion";
            btnEliminar.Visible = false;
            if (articulo != null) {                

                if (detalle == 1)
                {
                    eliminarTextBox();
                }
                else if (detalle == 2)
                {
                    eliminarTextBox();
                    btnEliminar.Visible = true;
                }
                else if (articulo != null)
                {
                    lblDetalleTextId.Text = articulo.Id.ToString();
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDetalle.Text = articulo.Descripcion;
                    txtMarca.SelectedValue = articulo.Marca.Id;
                    txtCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString("0.00");
                    txtImagen.Text = articulo.Imagen;
                    agregarImg(articulo.Imagen);
                    btnAgregar.Visible = false;
                }
            }
           
            else
            {
                btnAgregar.Visible = true;
                btnModificar.Visible = false;
                lblDetalleTextId.Text = ultimoId().ToString();
            }
            

        }

        
        


        //FUNCION PARA ELIMINAR LOS TEXTBOX
        private void eliminarTextBox()
        {
            lblDetalleTextId.Text = articulo.Id.ToString();
            lblDetalleTextCodigo.Text = articulo.Codigo;
            lblDetalleTextNombre.Text = articulo.Nombre;
            lblDetalleTextDetalle.Text = articulo.Descripcion;
            lblDetalleTextMarca.Text = articulo.Marca.Descripcion;
            lblDetalleTextCategoria.Text = articulo.Categoria.Descripcion;
            lblDetalleTextPrecio.Text = articulo.Precio.ToString("0.00");
            txtNombre.Visible = false;
            txtCategoria.Visible = false;
            txtCodigo.Visible = false;
            txtMarca.Visible = false;
            txtPrecio.Visible = false;
            txtDetalle.Visible = false;
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            txtImagen.Visible = false;
            lblImagen.Visible = false;
            lblDetalleTextId.Visible = true;
            btnAgregarImagen.Visible = false;
            lblIdDetalle.Visible = true;

            agregarImg(articulo.Imagen);
        }




        //FUNCION PARA AGREGAR UN ARTICULO
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                fondoCamposObligatorios();
                if (txtCodigo.BackColor != Color.Red && txtNombre.BackColor != Color.Red && txtPrecio.BackColor != Color.Red)
                {
                    DialogResult result = MessageBox.Show("Estas agregando un Articulo nuevo. Estas seguro?", "AGREGANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {

                        tomarDatosNegocio(new ArticuloNegocio(), 1);

                    }
                }
                else
                    return;      
        }
        //MODIFICAMOS EL ARTICULO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                fondoCamposObligatorios();
                if (txtCodigo.BackColor != Color.Red && txtNombre.BackColor != Color.Red && txtPrecio.BackColor != Color.Red)
                {
                    DialogResult result = MessageBox.Show($"Estas modificando e; siguiente Articulo: {articulo.Nombre}. Estas seguro?", "MODIFICANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                        tomarDatosNegocio(new ArticuloNegocio(), 0);
                }
                else
                    return;
           
        }







        //FUNCION PARA TRAER LOS DATOS DEL DATAGRIDVIEW DE ARTICULOS
        private void tomarDatosNegocio(ArticuloNegocio negocio, int numero)
        {
            if (articulo == null)
                articulo = new Articulo();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDetalle.Text;
                articulo.Marca = (Marca)txtMarca.SelectedItem;
                articulo.Categoria = (Categoria)txtCategoria.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Descripcion = txtDetalle.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text, CultureInfo.InvariantCulture);
               
                
                if (numero == 1)
                {
                    negocio.agregar(articulo);
                    guardarImagenLocal(archivo);
                    MessageBox.Show("Se agrego Exitosamente");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Se Modifico Exitosamente");
                }



                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       

        





        //EVENTO AL SALIR DEL CUADRO DE TEXTO IMAGEN CARGAMOS LA IMAGEN
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            agregarImg(txtImagen.Text);
        }

        //FUNCION PARA CARGAR LA IMAGEN AL BOX
        private void agregarImg(string img)
        {
            try
            {
                pbxDetalleImagen.Load(img);
            }
            catch (Exception ex)
            {
                pbxDetalleImagen.Load("https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-image_large.png?format=jpg&quality=90&v=1530129081");

            }
        }







        //TOMAMOS IMAGEN LOCAL
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg| png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                agregarImg(archivo.FileName);


            }

        }
        //FUNCION PARA GUARDAR IMAGEN LOCAL
        private void guardarImagenLocal(OpenFileDialog archivo)
        {
            if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["catalogo-martini"] + archivo.SafeFileName);

        }






        //FUNCION PARA SALIR DEL FORM
        private void btnSalirArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }





        //ELIMINAR SELECCIONADO
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Estas eliminado el siguiente Articulo: {articulo.Nombre}. Estas seguro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminar(articulo);
            }
            Close();



        }





        //FUNCION PARA TOMAR EL ULTIMO ID
        private int ultimoId()
        {
            
            
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                int id = articuloNegocio.listar().Max(obj => obj.Id) + 1;
            



            return id;
        }



        //FUNCIONES PARA VALIDAR
        private bool sinNumeros(string cadena)
        {
            foreach (char i in cadena)
            {
                if (!(char.IsNumber(i)) )
                    return true;
            }
            return false;
        }
        //FUNCION CAMPOS OBLIGATORIOS
        private bool campoObligatorio(string cadena)
        {
            if (cadena.Length == 0)
                return true;
            return false;
        }
        //CAMBIAR FONDOS CAMPOS OBLIGATORIOS
        private void fondoCamposObligatorios()
        {
            if (campoObligatorio(txtCodigo.Text))
                txtCodigo.BackColor = Color.Red;
            else
                txtCodigo.BackColor = default;
            if (campoObligatorio(txtNombre.Text))
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = default;
            if (sinNumeros(txtPrecio.Text) || txtPrecio.Text == "")
                txtPrecio.BackColor = Color.Red;
            else
                txtPrecio.BackColor = default;
        }



        
    }
}
