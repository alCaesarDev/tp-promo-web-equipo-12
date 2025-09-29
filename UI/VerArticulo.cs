using Dominio;
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
    public partial class VerArticulo : Form
    {
        private Articulo articulo;
        private readonly List<Imagen> imagenes;

        public VerArticulo()
        {
            InitializeComponent();
        }
        public VerArticulo(Articulo articulo, List<Imagen> imagenes)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.imagenes = imagenes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerArticulo_Load(object sender, EventArgs e)
        {
            if (this.articulo != null)
            {
                lblVerCodigo.Text = articulo.Codigo;
                lblVerNombre.Text = articulo.Nombre;
                lblVerDescripcion.Text = articulo.Descripcion;
                lblVerMarca.Text = articulo.Marca.Descripcion;
                lblVerCategoria.Text = articulo.Categoria.Descripcion;
                lblVerPrecio.Text = articulo.Precio.ToString("C");

                panelImagenes.Controls.Clear();

                if (this.imagenes != null && imagenes.Count > 0)
                {
                    foreach (Imagen img in imagenes)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Width = 120;
                        pb.Height = 90;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;

                        try
                        {
                            if (!string.IsNullOrWhiteSpace(img.ImagenUrl))
                            {
                                if (img.ImagenUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                                    pb.Load(img.ImagenUrl);
                                else
                                    pb.Image = Image.FromFile(img.ImagenUrl);
                            }
                        }
                        catch
                        {
                            pb.BackColor = Color.LightGray;
                        }

                        panelImagenes.Controls.Add(pb);
                    }
                }
            }
        }


        private void btnCerrarVer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
