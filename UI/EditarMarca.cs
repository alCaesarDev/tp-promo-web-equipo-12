using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class EditarMarca : Form
    {
        private Marca marca = null;

        public EditarMarca()
        {
            InitializeComponent();
        }

        public EditarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Editar Descripción de Marca";
            if (marca != null)
            {
                txtbDescripcion.Text = marca.Descripcion;
            }
        }

        private void btnAceptarEditarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                {
                    MessageBox.Show("No hay ninguna marca para editar.");
                    return;
                }

                marca.Descripcion = txtbDescripcion.Text;

                if (string.IsNullOrEmpty(marca.Descripcion))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                negocio.Modificar(marca);

                MessageBox.Show("¡Editado exitosamente!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
