using System;

namespace TPPromoWeb_equipo_12A
{
    public class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Start(object sender, EventArgs e)
        {
            Response.Redirect("~/Paso1.aspx");
        }
    }
}