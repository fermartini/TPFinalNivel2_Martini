using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> list = new List<Categoria>();
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta("select * from categorias");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
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
        public void agregar(Categoria categoria)
        {
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta($"insert into categorias values ('{categoria.Descripcion}');");
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
        public void modificar(Categoria categoria)
        {
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta($"update CATEGORIAS set Descripcion = '{categoria.Descripcion}' where id={categoria.Id}");
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
        public List<Categoria> filtrar(string criterio, string filtro)
        {
            List<Categoria> list = new List<Categoria>();
            DatosNegocio datos = new DatosNegocio();
            try
            {
                string consulta = "select * from categorias where ";
                if(criterio == "Comienza con")
                {
                    consulta += $"descripcion like '{filtro}%'";
                }else if (criterio == "Termina con")
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
                    Categoria aux = new Categoria();
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
