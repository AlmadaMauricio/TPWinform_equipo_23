﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Tp2_Winform
{
    internal class ArticuloNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id ID,A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio, I.ImagenUrl Imagen from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.IdArticulo = (int)lector["ID"];
                    aux.CodArticulo = (string)lector["Codigo"];
                    aux.NombreArticulo = (string)lector["Nombre"];
                    aux.DescripcionArticulo = (string)lector["Descripcion"];
                    aux.Marcas = new Marcas();
                    aux.Marcas.DescripcionMarca = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.DescripcionCategoria = (string)lector["Categoria"];
                    aux.imagenes = new Imagenes();
                    aux.imagenes.ImagenUrl = (string)lector["Imagen"];
                    aux.Precio = (float)Convert.ToDecimal(lector["Precio"]);

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            { 
                throw ex;
            }

        }
    }
}
