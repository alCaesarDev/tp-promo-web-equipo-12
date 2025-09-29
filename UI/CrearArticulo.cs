using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace UI
{
    public partial class CrearArticulo : Form
    {
        public CrearArticulo()
        {
            InitializeComponent();
        }

        private void CrearArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripción";
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripción";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtCrearCodigoArticulo.Text) ||
                    string.IsNullOrWhiteSpace(txtCrearNombreArticulo.Text))
                {
                    MessageBox.Show("Los campos código y nombre son obligatorios");
                    return;
                }

                if (cboMarca.SelectedItem == null || cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una marca y una categoría.");
                    return;
                }

                nuevo.Codigo = txtCrearCodigoArticulo.Text;
                nuevo.Nombre = txtCrearNombreArticulo.Text;
                nuevo.Descripcion = txtCrearDescripcionArticulo.Text;

                if (!decimal.TryParse(txtCrearPrecioArticulo.Text, out decimal precio))
                {
                    MessageBox.Show("Por favor ,ingrese un número válido en el campo precio");
                    return;
                }

                nuevo.Precio = precio;
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (listImagenes.Items.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una imagen");
                    return;
                }

                List<Imagen> listadoImagenes = new List<Imagen>();
                foreach (string item in listImagenes.Items)
                {
                    Imagen imagen = new Imagen();
                    imagen.ImagenUrl = item;
                    listadoImagenes.Add(imagen);
                }

                nuevo.Imagenes = listadoImagenes;

                negocio.Agregar(nuevo);
                MessageBox.Show("Artículo agregado exitosamente");
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los datos" + ex.Message);
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen|*.jpg;*.png";
            dialog.Title = "Seleccione una o más imágenes";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listImagenes.Items.Clear();
                foreach (string file in dialog.FileNames)
                {
                    listImagenes.Items.Add(file);
                }
            }
        }
    }
}