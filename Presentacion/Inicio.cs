using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        private Form formularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
        }

        

        
        

       
        //ABRIR FORM LISTA ARTICULOS CON ARTICULOS
        private void btnArticulo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ListaArticulos());
        }

        //ABRIR FORM LISTA ARTICULOS CON DATOS MARCA
        private void btnMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            abrirFormulario(new ListaArticulos(marca));
        }

        //ABRIR FORM LISTA ARTICULOS CON DATOS DE CATEGORIA
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            abrirFormulario(new ListaArticulos(categoria));
        }







        //MOSTAR EL TXT BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tbxBuscar.Visible = true;
            abrirFormulario(new ListaArticulos());
        }

        //FUNCION PARA FILTAR ARTICULO RAPIDO
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            abrirFormulario(new ListaArticulos(tbxBuscar.Text));
        }
        
        //FUNCION PARA OCULTAR EL TEXTBOXDEL FILTRO
        private void tbxBuscar_Leave(object sender, EventArgs e)
        {
            tbxBuscar.Visible = false;
        }





        //FUNCION CERRAR VENTANA PRINCIPAL
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }





        //FUNCION PARA ABRIR LISTA DE ARTICULOS EN PANEL       

        private void abrirFormulario(Form formularioNuevo)
        {
            //Si existe un formulario activo lo cerramos
            if (formularioActivo != null)
                formularioActivo.Close();
            //agregamos el formulario a la variable
            formularioActivo = formularioNuevo;
            //el formulario se comportara como un control
            formularioNuevo.TopLevel = false;
            //Rellenamos el panel con el formulario
            formularioNuevo.Dock = DockStyle.Fill;
            //Agregamos el formulario a los controles del contenedor
            pnlContenido.Controls.Add(formularioNuevo);
            //Asociamos el panel con el formulario
            pnlContenido.Tag = formularioNuevo;
            //Traemos el formulario hacia el frente
            formularioNuevo.BringToFront();
            //mostramos el formulario
            formularioNuevo.Show();
        }



        //OCULTAR EL TXT BUSCAR AL CARGAR
        private void Inicio_Load(object sender, EventArgs e)
        {
            tbxBuscar.Visible = false;

        }


        //CERRAR FORM ACTIVO
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            abrirFormulario(inicio);
            inicio.Close();
        }
    }
}
