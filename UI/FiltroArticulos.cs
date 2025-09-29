using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FiltroArticulos : Form
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public FiltroArticulos()
        {
            InitializeComponent();
            this.Load += Cargar;
        }
        
        private void Cargar(object sender, EventArgs e)
        {
            txtCodigo.Text = Codigo ?? string.Empty;
            txtNombre.Text = Nombre ?? string.Empty;
        }

        private void ClickBotonFiltrar(object sender, EventArgs e)
        {
            Codigo = txtCodigo.Text;
            Nombre = txtNombre.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClickBotonCancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}