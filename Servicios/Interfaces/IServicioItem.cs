using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Servicios.Interfaces
{
    interface IServicioItem
    {

        IEnumerable<Item> ObtenerItems();

        String ObtenerNombre();

        void AddAlumno(long dni, string nombre, string apellido, DateTime fechaNacimiento);

        void UpdateAlumno(int id, long dni, string nombre, string apellido, DateTime fechaNacimiento);
    }
}
