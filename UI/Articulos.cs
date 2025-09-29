using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Negocio;
using Negocio.DTO;
using UI.Abstactos;
using UI.DTO;

namespace UI
{
    public class Articulos : Listado<ArticuloDto>
    {
        protected FiltroArticuloDto filtro = new FiltroArticuloDto();

        /**
         * Cargo los articulos para mostrar la tabla
         */
        protected override List<ArticuloDto> ObtenerRegistros()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> articulos = new List<Articulo>();

            if (filtro.Codigo != null || filtro.Nombre != null)
            {
                articulos = articuloNegocio.Filtrar(filtro);
            }
            else
            {
                articulos = articuloNegocio.Listar();
            }

            //Mapeo los resultados de la db con el dto
            return articulos.Select(a => new ArticuloDto
            {
                Id = a.Id,
                Codigo = a.Codigo,
                Nombre = a.Nombre,
                Descripcion = a.Descripcion,
                Marca = a.Marca?.Descripcion,
                Categoria = a.Categoria?.Descripcion,
                Precio = a.Precio.ToString("C2")
            }).ToList();
        }

        protected override string ObtenerTitulo()
        {
            return "Artículos";
        }

        protected override bool MostrarBotonVer() => true;
        protected override bool MostrarBotonFiltros() => true;

        protected override void ClickBotonVer(object sender, EventArgs e)
        {
            if (RegistroSeleccionado != null)
            {
                try
                {
                    int idSeleccionado = RegistroSeleccionado.Id;
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    Articulo articuloCompleto = negocio.BuscarPorId(idSeleccionado);
                    if (articuloCompleto != null)
                    {
                        ImagenNegocio imagenNegocio = new ImagenNegocio();
                        List<Imagen> imagenes = imagenNegocio.ListarPorArticulo(idSeleccionado);

                        VerArticulo formularioDetalle = new VerArticulo(articuloCompleto, imagenes);
                        formularioDetalle.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el artículo en la base de datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al buscar el detalle del artículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor,seleccione un artículo para ver su detalle");
            }
        }

        protected override void ClickBotonFiltros(object sender, EventArgs e)
        {
            FiltroArticulos modal = new FiltroArticulos { Codigo = filtro.Codigo, Nombre = filtro.Nombre };

            var result = modal.ShowDialog();

            if (result == DialogResult.OK)
            {
                filtro.Codigo = modal.Codigo;
                filtro.Nombre = modal.Nombre;
                CargarRegistros(sender, e);
            }
        }

        protected override void ClickBotonEditar(object sender, EventArgs e)
        {
            if (RegistroSeleccionado != null)
            {
                try
                {
                    int idSeleccionado = RegistroSeleccionado.Id;
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    Articulo articuloCompleto = negocio.BuscarPorId(idSeleccionado);
                    if (articuloCompleto != null)
                    {
                        EditarArticulo formularioEdicion = new EditarArticulo(articuloCompleto);
                        formularioEdicion.ShowDialog();
                        CargarRegistros(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el artículo en la base de datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al buscar el artículo para editar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para editar");
            }
        }

        protected override void ClickBotonEliminar(object sender, EventArgs e)
        {
            if(RegistroSeleccionado != null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articuloAEliminar = negocio.BuscarPorId(RegistroSeleccionado.Id);
                EliminarArticulo ventanaArticulo = new EliminarArticulo(articuloAEliminar);
                DialogResult resultado = ventanaArticulo.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    CargarRegistros(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un artículo para eliminar");
            }
        }

        protected override void ClickBotonCrear(object sender, EventArgs e)
        {
            CrearArticulo ventana = new CrearArticulo();
            ventana.ShowDialog();
            CargarRegistros(sender, e);
        }
    }
}