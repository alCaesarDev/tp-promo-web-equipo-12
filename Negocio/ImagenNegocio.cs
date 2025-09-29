using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio;
using Infraestructura;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarPorArticulo(int articuloId)
        {
            List<Imagen> lista = new List<Imagen>();
            SqlConnection conexion = null;
            SqlCommand comando = null;
            SqlDataReader lector = null;

            try
            {
                conexion = BaseDeDatos.ObtenerConexion();
                string consulta = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo";

                comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@idArticulo", articuloId);

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen imagen = new Imagen
                    {
                        Id = (int)lector["Id"],
                        IdArticulo = (int)lector["IdArticulo"],
                        ImagenUrl = lector["ImagenUrl"].ToString()
                    };

                    lista.Add(imagen);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar imágenes", ex);
            }
            finally
            {
                conexion?.Close();
            }

            return lista;
        }

        public void Agregar(Imagen nuevo)
        {
            SqlConnection conexion = null;
            try
            {
                conexion = BaseDeDatos.ObtenerConexion();
                string consulta = @"
                INSERT INTO IMAGENES (IdArticulo, ImagenUrl) 
                VALUES (@IdArticulo, @ImagenUrl);
                ";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdArticulo", nuevo.IdArticulo);
                comando.Parameters.AddWithValue("@ImagenUrl", nuevo.ImagenUrl);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la imagen", ex);
            }
            finally
            {
                conexion?.Close();
            }
        }
    }
}