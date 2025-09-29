using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class CrearMarca : Form
    {
        public CrearMarca()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                Marca nuevaMarca = new Marca();
                nuevaMarca.Descripcion = txtDescripcionMarca.Text;

                if (string.IsNullOrEmpty(nuevaMarca.Descripcion))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                negocio.Agregar(nuevaMarca);
                MessageBox.Show("Agregado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}