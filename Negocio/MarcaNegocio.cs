using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> list = new List<Marca>();
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta("select * from marcas");
                datos.ejecutarConsulta();
                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector[0];
                    aux.Descripcion = (string)datos.Lector[1];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Marca marca)
        {
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta($"insert into marcas values ('{marca.Descripcion}');");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Marca marca)
        {
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta($"update marcas set Descripcion = '{marca.Descripcion}' where id={marca.Id};");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Marca> filtrar(string criterio, string filtro)
        {
            List<Marca> list = new List<Marca>();
            DatosNegocio datos = new DatosNegocio();
            try
            {
                string consulta = "select * from marcas where ";
                if (criterio == "Comienza con")
                {
                    consulta += $"descripcion like '{filtro}%'";
                }
                else if (criterio == "Termina con")
                {
                    consulta += $"descripcion like '%{filtro}'";
                }
                else
                {
                    consulta += $"descripcion like '%{filtro}%'";
                }
                datos.realizarConsulta(consulta);
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector[0];
                    aux.Descripcion = (string)datos.Lector[1];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
    
}
