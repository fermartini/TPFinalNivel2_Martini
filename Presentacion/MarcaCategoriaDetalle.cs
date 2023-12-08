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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentacion
{
    public partial class MarcaCategoriaDetalle : Form
    {
        Marca marca = null;
        Categoria categoria = null;
        int modificareliminar = 0;
        public MarcaCategoriaDetalle()
        {
            InitializeComponent();
        }
        public MarcaCategoriaDetalle(Marca marca, int modificareliminar)
        {
            InitializeComponent();
            this.marca = marca;
            this.modificareliminar = modificareliminar;
        }
        public MarcaCategoriaDetalle(Categoria categoria, int modificareliminar)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.modificareliminar = modificareliminar;
        }


        //CARGAR DATOS
        private void MarcaCategoriaDetalle_Load(object sender, EventArgs e)
        {
            if (marca != null && modificareliminar == 1)
            {
                lblId.Text = marca.Id.ToString();
                txtCodigo.Text = marca.Descripcion;
                btnAgregar.Visible = false;
                
            }
            else if(marca != null && modificareliminar == 2)
            {
                lblId.Text = ultimoId(1).ToString();
                txtCodigo.Text = marca.Descripcion;
                btnModificar.Visible = false;
            }
            else if (modificareliminar == 1)
            {
                lblId.Text = categoria.Id.ToString();
                txtCodigo.Text = categoria.Descripcion;
                btnAgregar.Visible = false;
            }
            else
            {
                lblId.Text = ultimoId(2).ToString();
                txtCodigo.Text = categoria.Descripcion;
                btnModificar.Visible = false;
            }
        }





        //FUNCION PARA AGREGAR UN MARCA O CATEGORIA
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            if (marca != null)
            {
                if (campoObligatorio(txtCodigo.Text))
                {
                    txtCodigo.BackColor = Color.Red;
                    return;

                }

                DialogResult result = MessageBox.Show("Estas agregando una Marca nueva. Estas seguro?", "AGREGANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    tomarDatosMarca(new MarcaNegocio(), 1);
            }
            else
            {
                if (campoObligatorio(txtCodigo.Text))
                {
                    txtCodigo.BackColor = Color.Red;
                    return;

                }
                DialogResult result = MessageBox.Show("Estas agregando una Categoria nueva. Estas seguro?", "AGREGANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    tomarDatosCateogira(new CategoriaNegocio(), 1);

            }
        }

        //MODIFICAMOS MARCA O CATEGORIA
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            if (marca != null)
            {
                if (campoObligatorio(txtCodigo.Text))
                {
                    txtCodigo.BackColor = Color.Red;
                    return;

                }
                DialogResult result = MessageBox.Show($"Estas modificando la siguiente Marca: {marca.Descripcion}. Estas seguro?", "MODIFICANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    tomarDatosMarca(marcaNegocio, 0);


            }
            else
            {
                if (campoObligatorio(txtCodigo.Text))
                {
                    txtCodigo.BackColor = Color.Red;
                    return;

                }
                DialogResult result = MessageBox.Show($"Estas modificando la siguiente Categoria: {categoria.Descripcion}. Estas seguro?", "MODIFICANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    tomarDatosCateogira(categoriaNegocio, 0);


            }
        }





        //FUNCION PARA TRAER LOS DATOS DEL DATAGRIDVIEW DE MARCA
        private void tomarDatosMarca(MarcaNegocio negocio, int numero)
        {
            if (marca == null)
                marca = new Marca();
            marca.Descripcion = txtCodigo.Text;
            if (numero == 1)
            {
                negocio.agregar(marca);
                MessageBox.Show("Se agrego Exitosamente");
            }
            else
            {
                negocio.modificar(marca);
                MessageBox.Show("Se modifico Exitosamente");
            }

            Close();
        }
        //FUNCION PARA TRAER LOS DATOS DEL DATAGRIDVIEW DE CATEGORIA
        private void tomarDatosCateogira(CategoriaNegocio negocio, int numero)
        {
            if (categoria == null)
                categoria = new Categoria();
            categoria.Descripcion = txtCodigo.Text;
            if (numero == 1)
            {
                negocio.agregar(categoria);
                MessageBox.Show("Se agrego Exitosamente");
            }
            else
            {
                negocio.modificar(categoria);
                MessageBox.Show("Se modifico Exitosamente");
            }

            Close();
        }






        //CERRAR FORM
        private void btnSalirArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }




        //FUNCION PARA TOMAR EL ULTIMO ID
        private int ultimoId(int a)
        {
            int id;
            if (a == 1)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                id = marcaNegocio.listar().Max(obj => obj.Id) + 1;
            }
            else
            {   
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                id = categoriaNegocio.listar().Max(obj => obj.Id) + 1;
            }
                

            
            return id;
        }



        //FUNCIONES PARA VALIDAR
        
        //FUNCION CAMPOS OBLIGATORIOS
        private bool campoObligatorio(string cadena)
        {
            if (cadena.Length == 0)
                return true;
            return false;
        }

        
    }
}
