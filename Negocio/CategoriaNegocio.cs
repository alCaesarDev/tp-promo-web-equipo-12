using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Dominio;
using Infraestructura;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection conexion = null;

            try
            {
                conexion = BaseDeDatos.ObtenerConexion();
                string consulta = @"
                SELECT Id,
                       Descripcion
                FROM CATEGORIAS 
                ";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = (int)lector["Id"],
                        Descripcion = lector["Descripcion"].ToString(),
                    };

                    lista.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar categorias", ex);
            }
            finally
            {
                conexion?.Close();
            }

            return lista;






        }

        public void agregar(Categoria categoria)
        {


            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO Categorias (Descripcion) VALUES (@Descripcion)", conexion);
                comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                comando.ExecuteNonQuery();
            }
        }




        public void Modificar(Categoria categoria)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @Descripcion WHERE Id = @Id");

                datos.setearParametro("@Descripcion", categoria.Descripcion);
                datos.setearParametro("@Id", categoria.Id);
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

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM CATEGORIAS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
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
    }
}