using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class EliminarMarca : Form
    {
        private readonly Marca MarcaAEliminar;

        public EliminarMarca(Marca marca)
        {
            InitializeComponent();
            MarcaAEliminar = marca;
            Load += EliminarMarca_Load;
        }

        private void EliminarMarca_Load(object sender, EventArgs e)
        {
            if (MarcaAEliminar != null)
            {
                txtbDescripcionEliminarMarca.Text = MarcaAEliminar.Descripcion;
                txtbDescripcionEliminarMarca.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                negocio.Eliminar(MarcaAEliminar.Id);
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("¡Eliminado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}