using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> list = new List<Articulo>();
            DatosNegocio datos = new DatosNegocio();
            try
			{
                datos.realizarConsulta("select a.id, a.Codigo, a.Nombre, a.Descripcion,a.idMarca, m.descripcion,a.idCategoria, c.descripcion , a.ImagenUrl, a.Precio from ARTICULOS as a left join categorias as c on c.id = a.idCategoria left join marcas as m on m.id = a.idMarca;");
                datos.ejecutarConsulta();
                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector[0];
                    aux.Codigo = (string)datos.Lector[1];
                    aux.Nombre = (string)datos.Lector[2];
                    aux.Descripcion = (string)datos.Lector[3];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector[4];
                    aux.Marca.Descripcion = (string)(datos.Lector[5]);
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector[6];
                    aux.Categoria.Descripcion = (string)datos.Lector[7];
                    aux.Imagen = (string)datos.Lector[8];
                    aux.Precio = (decimal)datos.Lector[9];
                    
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
        public void agregar(Articulo articulo)
        {
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta($"insert into articulos values ('{articulo.Codigo}','{articulo.Nombre}' ,'{articulo.Descripcion}',{articulo.Marca.Id},{articulo.Categoria.Id},'{articulo.Imagen}',{articulo.Precio});");
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
        public void modificar(Articulo articulo)
        {
            
            DatosNegocio datos = new DatosNegocio();
            try
            {
                datos.realizarConsulta($"update ARTICULOS set Codigo = '{articulo.Codigo}', nombre='{articulo.Nombre}', Descripcion ='{articulo.Descripcion}', IdMarca={articulo.Marca.Id}, IdCategoria={articulo.Categoria.Id}, ImagenUrl='{articulo.Imagen}', Precio={articulo.Precio} where id={articulo.Id};");
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
        public void eliminar(Articulo articulo)
        {
            DatosNegocio datos = new DatosNegocio();
            
            try
            {                
                datos.realizarConsulta($"delete ARTICULOS where id={articulo.Id};");
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
        public List<Articulo> filtrar(string atributo, string criterio, string filtro)
        {

            List<Articulo> list = new List<Articulo>();
            DatosNegocio datos = new DatosNegocio();
            try
            {
                string consulta = "select a.id, a.Codigo, a.Nombre, a.Descripcion,a.idMarca, m.descripcion,a.idCategoria, c.descripcion , a.ImagenUrl, a.Precio from ARTICULOS as a left join categorias as c on c.id = a.idCategoria left join marcas as m on m.id = a.idMarca WHERE ";
                
                switch (criterio)
                {
                    case "Comienza con":
                        switch (atributo)
                        {
                            case "Codigo":
                                consulta += $"Codigo LIKE '{filtro}%';";
                                break;
                            case "Nombre":
                                consulta += $"Nombre LIKE '{filtro}%';";
                                break;
                            case "Marca":
                                consulta += $"m.Descripcion LIKE '{filtro}%';";
                                break;
                            default:
                                consulta += $"c.Descripcion LIKE '{filtro}%';";
                                break;
                        }
                        break;
                    case "Termina con":
                        switch (atributo)
                        {
                            case "Codigo":
                                consulta += $"Codigo LIKE '%{filtro}';";
                                break;
                            case "Nombre":
                                consulta += $"Nombre LIKE '%{filtro}';";
                                break;
                            case "Marca":
                                consulta += $"m.Descripcion LIKE '%{filtro}';";
                                break;
                            default:
                                consulta += $"c.Descripcion LIKE '%{filtro}';";
                                break;
                        }
                        break;
                    case "Contiene":
                        switch (atributo)
                        {
                            case "Codigo":
                                consulta += $"Codigo LIKE '%{filtro}%';";
                                break;
                            case "Nombre":
                                consulta += $"Nombre LIKE '%{filtro}%';";
                                break;
                            case "Marca":
                                consulta += $"m.Descripcion LIKE '%{filtro}%';";
                                break;
                            default:
                                consulta += $"c.Descripcion LIKE '%{filtro}%';";
                                break;
                        }
                        break;
                    case "Mayor que":
                        consulta += $"Precio > {filtro};";
                        break;
                    case "Menor que":
                        consulta += $"Precio < {filtro};";
                        break;
                    default:
                        consulta += $"Precio = {filtro};";
                        break;

                }
                
                
             
                

                datos.realizarConsulta(consulta);
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector[0];
                    aux.Codigo = (string)datos.Lector[1];
                    aux.Nombre = (string)datos.Lector[2];
                    aux.Descripcion = (string)datos.Lector[3];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector[4];
                    aux.Marca.Descripcion = (string)(datos.Lector[5]);
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector[6];
                    aux.Categoria.Descripcion = (string)datos.Lector[7];
                    aux.Imagen = (string)datos.Lector[8];
                    aux.Precio = (decimal)datos.Lector[9];

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
