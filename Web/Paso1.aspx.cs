using System;
using System.Web.UI;
using Negocio;

namespace TPPromoWeb_equipo_12A
{
    public partial class Paso1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void btn_voucher_Click(object sender, EventArgs e)
        {
            string numeroVoucher = txtVoucher.Text.Trim();
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            string resultadoValidacion = voucherNegocio.EstaDiponible(numeroVoucher);

            if (resultadoValidacion == "OK")
            {
                lblVoucherMessage.Text = "";
                Session.Add("voucher", numeroVoucher);
                Response.Redirect("Paso2.aspx");
            }
            else
            {
                lblVoucherMessage.ForeColor = System.Drawing.Color.Red; 
                lblVoucherMessage.Text = resultadoValidacion;
            }
        }
    }
}