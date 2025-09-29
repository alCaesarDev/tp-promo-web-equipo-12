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
    public partial class CrearCategoria : Form
    {
        
        public CrearCategoria()
        {
            InitializeComponent();
            
        }
      
    
        private void button1_Click(object sender, EventArgs e)
        {

            Categoria nuevaCategoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
              

                nuevaCategoria.Descripcion = txtIngreseDescripcion.Text;
                if (string.IsNullOrEmpty(nuevaCategoria.Descripcion))
                {

                    MessageBox.Show("Debe ingresar una descripcion");
                    return;
                }


                negocio.agregar(nuevaCategoria);


                MessageBox.Show("Categoria Agregada exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
