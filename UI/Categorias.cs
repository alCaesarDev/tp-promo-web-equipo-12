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
    public class Categorias : Listado<CategoriaDto>
    {
        /**
         * Cargo los categorias para mostrar la tabla
         */
        protected override List<CategoriaDto> ObtenerRegistros()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.Listar();

            //Mapeo los resultados de la db con el dto
            return categorias.Select(a => new CategoriaDto
            {
                Id = a.Id,
                Descripcion = a.Descripcion,
            }).ToList();
        }

        protected override string ObtenerTitulo()
        {
            return "Categorías";
        }

        protected override void ClickBotonVer(object sender, EventArgs e)
        {
        }

        protected override void ClickBotonFiltros(object sender, EventArgs e)
        {
        }

        protected override bool MostrarBotonVer() => false;
        protected override bool MostrarBotonFiltros() => false;

        protected override void ClickBotonEditar(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                Id = RegistroSeleccionado.Id,
                Descripcion = RegistroSeleccionado.Descripcion
            };
            EditarCategoria ventana = new EditarCategoria(categoria);
            ventana.ShowDialog();
            CargarRegistros(sender, e);
        }

        protected override void ClickBotonEliminar(object sender, EventArgs e)
        {
            if (RegistroSeleccionado != null)
            {
                Categoria categoriaEliminar = new Categoria
                {
                    Id = RegistroSeleccionado.Id,
                    Descripcion = RegistroSeleccionado.Descripcion
                };
                EliminarCategoria ventana = new EliminarCategoria(categoriaEliminar);
                ventana.ShowDialog();
                CargarRegistros(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor , seleccione una categoría para eliminar");
            }
        }

        protected override void ClickBotonCrear(object sender, EventArgs e)
        {
            CrearCategoria ventana = new CrearCategoria();
            ventana.ShowDialog();
            CargarRegistros(sender, e);
        }
    }
}