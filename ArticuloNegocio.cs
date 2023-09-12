using System;
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
                conexion.ConnectionString = "server=.\\SQLLab3; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from ARTICULOS";

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
                    //aux.Precio = (float)lector["Precio"];

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
