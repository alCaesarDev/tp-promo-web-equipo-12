using System;
using System.Web;
using Negocio;
using System.Web.Script.Serialization;

namespace TPPromoWeb_equipo_12A
{
    public class VoucherValidator : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string numeroVoucher = context.Request.QueryString["numero"];

            VoucherNegocio voucherNegocio = new VoucherNegocio();
            string resultado = voucherNegocio.EstaDiponible(numeroVoucher);

            bool esExitoso = (resultado == "OK");

            var respuesta = new
            {
                success = esExitoso,
                message = resultado
            };

            context.Response.ContentType = "application/json";
            var jsonSerializer = new JavaScriptSerializer();
            string json = jsonSerializer.Serialize(respuesta);

            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}