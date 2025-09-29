using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Negocio;
using UI.Abstactos;
using UI.DTO;

namespace UI
{
    public class Marcas : Listado<MarcaDto>
    {
        /**
         * Cargo los marcas para mostrar la tabla
         */
        protected override List<MarcaDto> ObtenerRegistros()
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                List<Marca> marcas = marcaNegocio.Listar();
                return marcas.Select(a => new MarcaDto()
                {
                    Id = a.Id,
                    Descripcion = a.Descripcion,
                }).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        protected override bool MostrarBotonVer() => false;
        protected override bool MostrarBotonFiltros() => false;

        protected override void ClickBotonFiltros(object sender, EventArgs e)
        {
            
        }
        
        protected override string ObtenerTitulo()
        {
            return "Marcas";
        }

        protected override void ClickBotonVer(object sender, EventArgs e)
        {
            MessageBox.Show($"Aca van los detalles de la marca {RegistroSeleccionado.Id}.");
        }

        protected override void ClickBotonEditar(object sender, EventArgs e)
        {
            if (RegistroSeleccionado != null)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                Marca marca = negocio.Buscar(RegistroSeleccionado.Id);

                EditarMarca ventana = new EditarMarca(marca);

                ventana.ShowDialog();
                CargarRegistros(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una marca para editar.");
            }
        }

        protected override void ClickBotonEliminar(object sender, EventArgs e)
        {
            if (RegistroSeleccionado != null)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                Marca marcaAEliminar = negocio.Buscar(RegistroSeleccionado.Id);

                EliminarMarca ventana = new EliminarMarca(marcaAEliminar);
                DialogResult resultado = ventana.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CargarRegistros(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una marca para eliminar");
            }
        }

        protected override void ClickBotonCrear(object sender, EventArgs e)
        {
            CrearMarca ventana = new CrearMarca();
            ventana.ShowDialog();
            CargarRegistros(sender, e);
        }
    }
}