using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DatosNegocio
    {
        //Creamos las variables para conectar la BBDD
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        
        public DatosNegocio() 
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        //FUNCIONES 

        //Seteamos la consulta
        public  void realizarConsulta(string consulta)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
        }

        //Ejecutamos la consulta
        public void ejecutarConsulta()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                lector = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Ejecutamos una Accion, UPDATE, DELETE, INSERT
        public void ejecutarAccion()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Cerramos la conexion
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conn.Close();
        }
        
    }
}
