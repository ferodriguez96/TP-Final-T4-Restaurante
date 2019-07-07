using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Zona
    {
        #region Properties
        public int Id { get; set; }
        public string descripcion { get; set; }
        public virtual IEnumerable<Mesa> Mesas { get; set; }
        public Mozo mozo { get; set; }
        #endregion

        #region Constructors
        public Zona()
        {
            Mesas = new HashSet<Mesa>();
        }
        #endregion
    }
}
