using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Infraestructura;

namespace Negocio
{
    public class VoucherNegocio
    {
        public string EstaDiponible(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                return "El código de voucher no puede estar vacío.";

            SqlConnection conexion = null;
            try
            {
                conexion = BaseDeDatos.ObtenerConexion();
                string sql = "SELECT IdCliente FROM Vouchers WHERE CodigoVoucher = @codigo";
                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo.Trim());
                    var result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        return "El voucher no existe.";
                    }

                    if (result == DBNull.Value || (result is string s && string.IsNullOrEmpty(s)))
                    {
                        return "OK";
                    }

                    return "El voucher ya fue utilizado.";
                }
            }
            catch (Exception ex)
            {
                return "Ocurrió un error al verificar el voucher.";
            }
            finally
            {
                conexion?.Close();
            }
        }

        public void Modificar(Voucher voucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "UPDATE Vouchers " +
                    "SET IdCliente = @idCliente, FechaCanje = @fechaCanje, IdArticulo = @idArticulo " +
                    "WHERE CodigoVoucher = @codigoVoucher");

                datos.setearParametro("@idCliente", voucher.IdCliente);
                datos.setearParametro("@fechaCanje", voucher.FechaCanje);
                datos.setearParametro("@idArticulo", voucher.IdArticulo);
                datos.setearParametro("@codigoVoucher", voucher.CodigoVoucher);

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

        public Voucher Encontrar(string codigoVoucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo " +
                    "FROM Vouchers WHERE CodigoVoucher = @codigoVoucher");

                datos.setearParametro("@codigoVoucher", codigoVoucher);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Voucher voucher = new Voucher
                    {
                        CodigoVoucher = datos.Lector["CodigoVoucher"].ToString(),
                        IdCliente = datos.Lector["IdCliente"] != DBNull.Value ? (int?)Convert.ToInt32(datos.Lector["IdCliente"]) : null,
                        FechaCanje = datos.Lector["FechaCanje"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(datos.Lector["FechaCanje"]) : null,
                        IdArticulo = datos.Lector["IdArticulo"] != DBNull.Value ? (int?)Convert.ToInt32(datos.Lector["IdArticulo"]) : null
                    };

                    return voucher;
                }

                return null;
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