using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulos> listar()
        {
			List<Articulos> lista = new List<Articulos>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("SELECT A.Id ID,A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio, I.ImagenUrl Imagen from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo");
				datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.IdArticulo = (int)datos.Lector["ID"];
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    aux.Marcas = new Marcas();
                    aux.Marcas.DescripcionMarca = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    aux.imagenes = new Imagenes();
                    aux.imagenes.ImagenUrl = (string)datos.Lector["Imagen"];
                    aux.Precio = (float)Convert.ToDecimal(datos.Lector["Precio"]);

                    lista.Add(aux);
                }

                return lista;
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
