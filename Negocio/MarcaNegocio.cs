using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio;
using Infraestructura;

namespace Negocio
{
    public class MarcaNegocio
    {
        public Marca Buscar(int id)
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
                    return new Marca
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

        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = null;

            try
            {
                conexion = BaseDeDatos.ObtenerConexion();
                string consulta = @"
                SELECT Id,
                       Descripcion
                FROM MARCAS 
                ";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca marca = new Marca
                    {
                        Id = (int)lector["Id"],
                        Descripcion = lector["Descripcion"].ToString(),
                    };

                    lista.Add(marca);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar marcas", ex);
            }
            finally
            {
                conexion?.Close();
            }

            return lista;
        }

        public void Agregar(Marca marca)
        {
            SqlConnection conexion = BaseDeDatos.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)", conexion);
                comando.Parameters.AddWithValue("@Descripcion", marca.Descripcion);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion?.Close();
            }
        }

        public void Modificar(Marca marca)
        {
            SqlConnection conexion = BaseDeDatos.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id", conexion);
                comando.Parameters.AddWithValue("@Descripcion", marca.Descripcion);
                comando.Parameters.AddWithValue("@Id", marca.Id);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion?.Close();
            }
        }

        public void Eliminar(int id)
        {
            SqlConnection conexion = BaseDeDatos.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("DELETE FROM MARCAS WHERE Id = @Id", conexion);
                comando.Parameters.AddWithValue("@Id", id);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion?.Close();
            }
        }
    }
}