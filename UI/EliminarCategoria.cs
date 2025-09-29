using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace UI
{
    public partial class EliminarCategoria : Form
    {
        private Categoria categoriaEliminar;
        public EliminarCategoria(Categoria categoria)
        {
            InitializeComponent();
            categoriaEliminar = categoria;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       

        private void btnEliminarAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.Eliminar(categoriaEliminar.Id);
                MessageBox.Show("Categoría eliminada exitosamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();

               
            }
        }
    }
}
