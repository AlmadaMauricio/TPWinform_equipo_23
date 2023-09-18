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
                datos.setearConsulta("SELECT A.Id ID,A.Codigo, A.Nombre, A.Descripcion, A.IdMarca IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.Precio, I.ImagenUrl Imagen from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS C ON C.Id = A.IdCategoria left join IMAGENES I ON I.IdArticulo = A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.IdArticulo = (int)datos.Lector["ID"];
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marcas = new Marcas();
                    aux.Marcas.DescripcionMarca = (string)datos.Lector["Marca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    aux.imagenes = new Imagenes();
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Imagen"))))
                    {
                        aux.imagenes.ImagenUrl = (string)datos.Lector["Imagen"];
                    }
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
        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,IdMarca, IdCategoria, Precio) VALUES (@codArticulo, @nombreArticulo, @descripcionArticulo, @IdMarca, @IdCategoria, @precio)");
                //datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio) VALUES (@codArticulo, @nombreArticulo, @descripcionArticulo, @precio)");
                datos.setearParametro("@codArticulo", nuevo.CodArticulo);
                datos.setearParametro("@nombreArticulo", nuevo.NombreArticulo);
                datos.setearParametro("@descripcionArticulo", nuevo.DescripcionArticulo);
                datos.setearParametro("@IdMarca", nuevo.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria);
                //datos.setearParametro("@ImagenUrl", nuevo.imagenes.ImagenUrl);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
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
