using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class EditarCategoria : Form
    {
        private Categoria categoria;
        public EditarCategoria( Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            txtModificarDescripcion.Text = categoria.Descripcion;
            
        }


        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtModificarDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía");
                    return;
                }

                categoria.Descripcion = txtModificarDescripcion.Text;

                negocio.Modificar(categoria);
                MessageBox.Show("Editado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                File.WriteAllText("error.log", ex.ToString());
                MessageBox.Show("Se produjo un error inesperado.Revisa el archivo 'error.log' para ver los detalles.");
                
                
            }
        }


        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            Close();
        }


        
    }
}
