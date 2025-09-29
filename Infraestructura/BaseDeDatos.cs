using System.Configuration;
using System.Data.SqlClient;

namespace Infraestructura
{
    public static class BaseDeDatos
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["DATABASE"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}