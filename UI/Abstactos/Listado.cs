using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Abstactos
{
    public abstract partial class Listado<T> : UserControl
    {
        protected T RegistroSeleccionado;

        protected Listado()
        {
            InitializeComponent();
        }

        protected abstract string ObtenerTitulo();

        protected abstract void ClickBotonCrear(object sender, EventArgs e);
        protected abstract void ClickBotonEditar(object sender, EventArgs e);
        protected abstract bool MostrarBotonVer();
        protected abstract void ClickBotonEliminar(object sender, EventArgs e);
        protected abstract void ClickBotonVer(object sender, EventArgs e);

        protected abstract List<T> ObtenerRegistros();
        
        protected abstract bool MostrarBotonFiltros();

        protected abstract void ClickBotonFiltros(object sender, EventArgs e);

        protected void CargarRegistros(object sender, EventArgs e)
        {
            try
            {
                List<T> registros = ObtenerRegistros();
                tabla.DataSource = registros;
                
                //Si existe al menos un registro, lo selecciono y activo los botones
                if (registros.Count > 0)
                {
                    RegistroSeleccionado = (T)tabla.Rows[0].DataBoundItem;
                    botonVer.Enabled = true;
                    botonEditar.Enabled = true;
                    botonEliminar.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al cargar registros de la tabla: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickRegistro(object sender, DataGridViewCellEventArgs e)
        {
            // Me fijo que no haya clickeado en el header
            if (e.RowIndex < 0) return;
            //Agarro el item del registro
            RegistroSeleccionado = (T)tabla.Rows[e.RowIndex].DataBoundItem;
            botonVer.Enabled = true;
            botonEditar.Enabled = true;
            botonEliminar.Enabled = true;
        }
    }
}