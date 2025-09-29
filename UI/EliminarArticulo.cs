using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EliminarArticulo : Form
    {
        private Articulo articuloAEliminar;

        public EliminarArticulo(Articulo articulo)
        {
            InitializeComponent();
            articuloAEliminar = articulo;
        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            if (articuloAEliminar != null)
            {
                txtEliminarCodigoArticulo.Text = articuloAEliminar.Codigo;
                txtEliminarNombreArticulo.Text = articuloAEliminar.Nombre;
                txtEliminarDescripcionArticulo.Text = articuloAEliminar.Descripcion;
                txtEliminarPrecioArticulo.Text = articuloAEliminar.Precio.ToString();

                cboMarcaEliminarArticulo.Text = articuloAEliminar.Marca.Descripcion;
                cboEliminarArticuloCategoria.Text = articuloAEliminar.Categoria.Descripcion;

                txtEliminarCodigoArticulo.ReadOnly = true;
                txtEliminarNombreArticulo.ReadOnly = true;
                txtEliminarDescripcionArticulo.ReadOnly = true;
                txtEliminarPrecioArticulo.ReadOnly = true;
                cboMarcaEliminarArticulo.Enabled = false;
                cboEliminarArticuloCategoria.Enabled = false;
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Eliminar(articuloAEliminar.Id);
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("¡Eliminado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void btnCancelarArticuloEliminado_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}