using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Servicios.Interfaces
{
    interface IServicioCategoria
    {
        IEnumerable<Categoria> ObtenerCategorias();

        String ObtenerDescripcion(int Id);
        IEnumerable<Item> ObtenerItemsPorCategoria(int id);

        void AddCategoria(String descripcion);
        void UpdateCategoria(int id, String descripcion);
    }
}
