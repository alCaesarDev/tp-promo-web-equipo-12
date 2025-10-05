using System;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPPromoWeb_equipo_12A
{
    public partial class Paso3 : Page
    {
        protected TextBox dni;
        protected TextBox nombre;
        protected TextBox apellido;
        protected TextBox email;
        protected TextBox direccion;
        protected TextBox ciudad;
        protected TextBox codigoPostal;
        protected CheckBox aceptaTerminos;
        protected Button participar;

        protected Cliente cliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            string eventTarget = Request["__EVENTTARGET"];
            if (eventTarget == "Volver")
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void ParticiparClick(object sender, EventArgs e)
        {
            if (!ValidarFormulario() || !ValidarSession())
            {
                return;
            }

            GuardarDatos();
        }

        private bool ValidarSession()
        {
            if (Session["voucher"] == null)
            {
                MostrarMensaje("Debe ingresar un voucher.");
                return false;
            }

            if (Session["idArticuloSeleccionado"] == null)
            {
                MostrarMensaje("Debe seleccionar un artículo.");
                return false;
            }

            return true;
        }

        public void BuscarPorDni(object sender, EventArgs e)
        {
            if (dni.Text == "")
            {
                nombre.Text = "";
                apellido.Text = "";
                email.Text = "";
                direccion.Text = "";
                ciudad.Text = "";
                codigoPostal.Text = "";
                return;
            }

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            cliente = clienteNegocio.BuscarPorDocumento(dni.Text);

            if (cliente != null)
            {
                nombre.Text = cliente.Nombre;
                apellido.Text = cliente.Apellido;
                email.Text = cliente.Email;
                direccion.Text = cliente.Direccion;
                ciudad.Text = cliente.Ciudad;
                codigoPostal.Text = cliente.CP;
            }
            else
            {
                nombre.Text = "";
                apellido.Text = "";
                email.Text = "";
                direccion.Text = "";
                ciudad.Text = "";
                codigoPostal.Text = "";
            }
        }

        private void GuardarDatos()
        {
            int idArticulo = Convert.ToInt32(Session["idArticuloSeleccionado"]);
            string codigoVoucher = Session["voucher"]?.ToString();
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            int idClienteResultado;

            try
            {
                cliente = clienteNegocio.BuscarPorDocumento(dni.Text);
                if (cliente != null)
                {
                    clienteNegocio.Modificar(cliente);
                    idClienteResultado = cliente.Id;
                }
                else
                {
                    cliente = new Cliente();
                    cliente.Documento = dni.Text;
                    cliente.Nombre = nombre.Text;
                    cliente.Apellido = apellido.Text;
                    cliente.Ciudad = ciudad.Text;
                    cliente.CP = codigoPostal.Text;
                    cliente.Email = email.Text;
                    cliente.Direccion = direccion.Text;
                    cliente.Ciudad = ciudad.Text;

                    idClienteResultado = clienteNegocio.Crear(cliente);
                }

                Voucher voucher = voucherNegocio.Encontrar(codigoVoucher);

                if (voucher == null)
                {
                    MostrarMensaje("No se encontro el voucher");
                    return;
                }

                voucher.IdCliente = idClienteResultado;
                voucher.IdArticulo = idArticulo;
                voucher.FechaCanje = DateTime.Today;
                voucherNegocio.Modificar(voucher);

                try
                {
                    Notificador notificador = new Notificador();
                    notificador.Notificar(cliente.Email);
                    ClientScript.RegisterStartupScript(this.GetType(), "confirm",
                        "if(confirm('Formulario cargado con exito, se ha enviado un email de confirmacion, gracias por participar')) { __doPostBack('Volver',''); }", true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    ClientScript.RegisterStartupScript(this.GetType(), "confirm",
                        "if(confirm('Ha ocurrido un error al enviar el email, pero se cargado el formulario con exito.')) { __doPostBack('Volver',''); }", true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MostrarMensaje(e.Message);
            }
        }

        private bool ValidarFormulario()
        {
            string errores = "";

            if (string.IsNullOrWhiteSpace(dni.Text))
                errores += "El DNI es obligatorio.<br/>";
            else if (!Regex.IsMatch(dni.Text, @"^\d{7,8}$"))
                errores += "El DNI debe tener entre 7 y 8 dígitos numéricos.<br/>";

            if (string.IsNullOrWhiteSpace(nombre.Text))
                errores += "El nombre es obligatorio.<br/>";
            else if (nombre.Text.Length < 2)
                errores += "El nombre es demasiado corto.<br/>";

            if (string.IsNullOrWhiteSpace(apellido.Text))
                errores += "El apellido es obligatorio.<br/>";
            else if (apellido.Text.Length < 2)
                errores += "El apellido es demasiado corto.<br/>";

            if (string.IsNullOrWhiteSpace(email.Text))
                errores += "El email es obligatorio.<br/>";
            else if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errores += "El formato del email no es válido.<br/>";

            if (string.IsNullOrWhiteSpace(direccion.Text))
                errores += "La dirección es obligatoria.<br/>";

            if (string.IsNullOrWhiteSpace(ciudad.Text))
                errores += "La ciudad es obligatoria.<br/>";

            if (string.IsNullOrWhiteSpace(codigoPostal.Text))
                errores += "El código postal es obligatorio.<br/>";
            else if (!Regex.IsMatch(codigoPostal.Text, @"^\d{4,5}$"))
                errores += "El código postal debe ser numérico (4 o 5 dígitos).<br/>";

            if (!aceptaTerminos.Checked)
                errores += "Debe aceptar los términos y condiciones.<br/>";

            if (!string.IsNullOrEmpty(errores))
            {
                MostrarMensaje(errores, true);
                return false;
            }

            return true;
        }

        private void MostrarMensaje(string mensaje, bool esError = false)
        {
            string script = $"alert('{mensaje.Replace("<br/>", "\\n")}');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }
    }
}