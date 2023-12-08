
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ListaArticulos : Form
    {
        
        private List<Articulo> listaDeArticulos;
        private List<Marca> listaMarca;
        private List<Categoria> listaCategorias;
        private Marca marca = null;
        private Categoria categoria = null;
        private string algo = null;
        //PARA TRAER DE LA BBDD ARTICULOS
        public ListaArticulos()
        {
            InitializeComponent();
        }
        //PARA TRAER DE LA BASE DE DATOS MARCAS
        public ListaArticulos(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }
        //PARA TRAER DE LA BASE DE DATOS CATEGORIAS
        public ListaArticulos(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }
        //PARA FILTRAR
        public ListaArticulos(String algo)
        {
            InitializeComponent();
            this.algo = algo;
        }

        
        //FUNCIONES AL ABRIR FORMULARIO
        private void cargar()
        {
            //CARGA ARTICULOS
            if (marca == null && categoria == null)
            {
                ArticuloNegocio articulo = new ArticuloNegocio();
                cbxAtributo.Items.Clear();
                cbxAtributo.Items.Add("Categoria");
                cbxAtributo.Items.Add("Nombre");
                cbxAtributo.Items.Add("Marca");
                cbxAtributo.Items.Add("Categoria");
                cbxAtributo.Items.Add("Precio");
                cbxAtributo.SelectedIndex = 1;
                if (algo == null)
                {
                    listaDeArticulos = articulo.listar();
                }
                else
                {
                    listaDeArticulos = articulo.listar().FindAll(item => item.Codigo.ToUpper().Contains(algo.ToUpper()) || item.Nombre.ToUpper().Contains(algo.ToUpper()) || item.Descripcion.ToUpper().Contains(algo.ToUpper()) || item.Marca.Descripcion.ToUpper().Contains(algo.ToUpper()) || item.Categoria.Descripcion.ToUpper().Contains(algo.ToUpper()) || item.Precio.ToString("0.00").ToUpper().Contains(algo.ToUpper()));
                }
                dgvArticulos.DataSource = listaDeArticulos;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[6].Visible = false;
                dgvArticulos.Columns[7].Visible = false;
                if(listaDeArticulos.Count > 0)
                {
                    cargarImagen(listaDeArticulos[0].Imagen);
                    lblPrecio.Text = listaDeArticulos[0].Precio.ToString("0.00");
                    
                }
                dgvArticulos.Columns[1].Width = 50;
                dgvArticulos.Columns[2].Width = 100;
                dgvArticulos.Columns[3].Width = 300;
                dgvArticulos.Columns[4].Width = 100;
                dgvArticulos.Columns[5].Width = 100;

            }
            //CARGAR MARCA
            else if (categoria == null)
            {
                
                dgvArticulos.Height = 522;
                MarcaNegocio marca = new MarcaNegocio();
                cbxAtributo.Items.Add("Descripcion");
                listaMarca = marca.listar();
                dgvArticulos.DataSource = listaMarca;
                lblImagen.Visible = false;
                lblPrecio.Visible = false;
                lblPrecioTexto.Visible = false;
                pbxImagen.Visible = false;
                lblSigno.Visible = false;
                btnVerDetalles.Visible = false;
                btnEliminar.Visible = false;
                cbxAtributo.SelectedIndex = 0;

            }
            //CARGAR CATEGORIA
            else
            {                
                dgvArticulos.Height = 522;
                CategoriaNegocio categoria = new CategoriaNegocio();
                cbxAtributo.Items.Add("Descripcion");
                listaCategorias = categoria.listar();
                dgvArticulos.DataSource = listaCategorias;
                lblImagen.Visible = false;
                lblPrecio.Visible = false;
                lblPrecioTexto.Visible = false;
                pbxImagen.Visible = false;
                lblSigno.Visible = false;
                btnVerDetalles.Visible = false;
                cbxAtributo.SelectedIndex = 0;
                btnEliminar.Visible = false;
            }
        }
        private void ListaArticulos_Load(object sender, EventArgs e)
        {
            
            cargar();
            
            dgvArticulos.Columns[0].Width = 75;          
            
            cbxOrdenar.SelectedIndex = 0;

        }
        
     
       


        
        //ABRIR FORMULARIO VER DETALLE
        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (listaDeArticulos.Count > 0)
            {
                if (!(validarSeleccion()))
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloDetalles detalles = new ArticuloDetalles(seleccionado, 1);

                    detalles.ShowDialog();
                }
                    
                
                
            }


        }


        
        
        //FUNCIONES AGREGAR MODIFICAR ELIMINAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (marca == null && categoria == null)
            {
                
                    ArticuloDetalles detalles = new ArticuloDetalles();
                    detalles.ShowDialog();
                    cargar();
                    

            }
            else if (categoria == null)
            {
                MarcaCategoriaDetalle detalles = new MarcaCategoriaDetalle(new Marca(), 2);
                detalles.ShowDialog();
                cargar();
            }
            else
            {
                MarcaCategoriaDetalle detalles = new MarcaCategoriaDetalle(new Categoria(), 2);
                detalles.ShowDialog();
                cargar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
                return;
            if (marca == null && categoria == null)
            {
                if (listaDeArticulos.Count > 0)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    ArticuloDetalles detalles = new ArticuloDetalles(seleccionado);
                    detalles.ShowDialog();
                    
                    int id = seleccionado.Id;
                    foreach (DataGridViewRow fila in dgvArticulos.Rows)
                    {
                        int idNuevo = (int)fila.Cells["ID"].Value;
                        if (idNuevo == id)
                            fila.Selected = true;
                            
                    }
                    cargarImagen(seleccionado.Imagen);
                }

            }
            else if (categoria == null)
            {
                Marca seleccionado = (Marca)dgvArticulos.CurrentRow.DataBoundItem;
                MarcaCategoriaDetalle detalles = new MarcaCategoriaDetalle(seleccionado, 1);
                detalles.ShowDialog();

                int id = seleccionado.Id;
                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    int idNuevo = (int)fila.Cells["ID"].Value;
                    if (idNuevo == id)
                        fila.Selected = true;
                }
            }
            else
            {
                Categoria seleccionado = (Categoria)dgvArticulos.CurrentRow.DataBoundItem;
                MarcaCategoriaDetalle detalles = new MarcaCategoriaDetalle(seleccionado, 1);
                
                detalles.ShowDialog();

                int id = seleccionado.Id;
                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    int idNuevo = (int)fila.Cells["ID"].Value;
                    if (idNuevo == id)
                        fila.Selected = true;
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (validarSeleccion())
                return;
            
                if (listaDeArticulos.Count > 0)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloDetalles detalles = new ArticuloDetalles(seleccionado, 2);
                    detalles.ShowDialog();
                    cargar();
                }


        }
   
        
        
        
        //FUNCION DE FILTRADO
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (marca == null && categoria == null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    string atributo = cbxAtributo.SelectedItem.ToString();
                    string criterio = cbxOrdenar.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;
                    if (validarFiltro())
                        txtFiltro.BackColor = Color.Red;
                    else
                    {
                        txtFiltro.BackColor = default;
                        dgvArticulos.DataSource = negocio.filtrar(atributo, criterio, filtro);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else if (categoria == null)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                try
                {
                    string criterio = cbxOrdenar.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;
                    dgvArticulos.DataSource = negocio.filtrar(criterio, filtro);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                try
                {
                    string criterio = cbxOrdenar.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;
                    dgvArticulos.DataSource = negocio.filtrar(criterio, filtro);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }



        }

        //CAMBIAR LOS VALORES DEL CRITERIO EN EL FILTRO AL CAMBIAR EL ATRIBUTO
        private void cbxAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxAtributo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbxOrdenar.Items.Clear();
                cbxOrdenar.Items.Add("Mayor que");
                cbxOrdenar.Items.Add("Menor que");
                cbxOrdenar.Items.Add("Igual");
                cbxOrdenar.SelectedIndex = 0;
            }
            else
            {
                cbxOrdenar.Items.Clear();
                cbxOrdenar.Items.Add("Comienza con");
                cbxOrdenar.Items.Add("Termina con");
                cbxOrdenar.Items.Add("Contiene");
                cbxOrdenar.SelectedIndex = 0;
            }

        }

        
        
        
 
        //FUNCION CARGAR IMAGEN DE BBDD
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-image_large.png?format=jpg&quality=90&v=1530129081");

            }
        }

       

      
        
        //FUNCIONES PARA VALIDAR

        //VALIDAR EL FILTRO
        private bool validarFiltro()
        {
            if (cbxAtributo.Text == "Precio")
            {
                if (!(soloNumeros(txtFiltro.Text)) || txtFiltro.Text == "")
                    return true;
                else
                    return false;

            }
            else
                return false;
        }

        //VALIDAR SELECCION DATAGRIDVIEW
        private bool validarSeleccion()
        {
            if (dgvArticulos.SelectedCells.Count == 0)
                return true;
            return false;
        }

        //PEDIR SOLO NUMEROS
        private bool soloNumeros(string cadena)
        {
            foreach(char i in cadena)
            {
                if (!(char.IsNumber(i)))
                    return false;                     
            }
            return true;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (!(validarSeleccion()))
            {
                if (!(validarSeleccion()))
                {
                    if (marca == null && categoria == null)
                    {
                        if (listaDeArticulos.Count > 0)
                        {
                            try
                            {
                                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                                cargarImagen(seleccionado.Imagen);
                                lblPrecio.Text = seleccionado.Precio.ToString("0.00");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No hay items en la grilla");
                            }

                        }

                    }
                }

            }
        }
    }
}
