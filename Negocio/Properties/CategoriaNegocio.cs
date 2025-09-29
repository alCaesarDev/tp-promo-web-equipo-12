using System;
using System.Data.SqlClient;
using Dominio;
using Infraestructura;

namespace Negocio.Properties
{
    public class CategoriaNegocio
    {
        public Categoria Buscar(int id)
        {
            SqlConnection conexion = null;

            try
            {
                conexion = BaseDeDatos.ObtenerConexion();
                var consulta = "SELECT Id, Descripcion FROM MARCAS WHERE Id = @id";

                var comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", id);

                var lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    return new Categoria()
                    {
                        Id = (int)lector["Id"],
                        Descripcion = lector["Descripcion"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar marca", ex);
            }
            finally
            {
                conexion?.Close();
            }
        }
    }
}