using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace TPPromoWeb_equipo_12A
{
    public partial class Paso2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["idArticuloSeleccionado"] = null;
                CargarPremios();
            }
        }

        private void CargarPremios()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaPremios = negocio.ListarConRelaciones();

            if (listaPremios != null && listaPremios.Count > 0)
            {
                rptArticulos.DataSource = listaPremios;
                rptArticulos.DataBind();
            }
            else
            {
                pnlNoHayArticulos.Visible = true;
            }
        }

        protected string GetImageUrl(object imagenesObject)
        {
            var imagenes = imagenesObject as List<Dominio.Imagen>;
            if (imagenes != null && imagenes.Any())
            {
                return imagenes[0].ImagenUrl;
            }

            return "";
        }

        public string GetFirstImageUrl(object imagenes)
        {
            if (imagenes is List<Dominio.Imagen> listaImagenes && listaImagenes.Any())
            {
                return listaImagenes[0].ImagenUrl;
            }

            return "";
        }

        protected void rptArticulos_ItemCommand(object source,
            System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "ElegirPremio")
            {
                int idArticuloSeleccionado = Convert.ToInt32(e.CommandArgument);
                Session.Add("idArticuloSeleccionado", idArticuloSeleccionado);
                Response.Redirect("Paso3.aspx");
            }
        }
    }
}