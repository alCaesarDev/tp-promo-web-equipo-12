using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
