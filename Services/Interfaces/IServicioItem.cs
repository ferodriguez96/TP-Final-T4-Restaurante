using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Servicios.Interfaces
{
    interface IServicioItem
    {

        IEnumerable<Item> ObtenerItems();

        //Categoria ObtenerCategoria(int Id);
        


        void AddItem(string nombre, float precio, Categoria categoria);

        void UpdateItem(int Id, string nombre, float precio, Categoria categoria);
    }
}
