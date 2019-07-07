using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Mozo
    {
        #region Properties
        public int Id { get; set; }//puede ser el DNI
        public String nombre { get; set; }
        public String apellido{ get; set; }
        //public Zona[] zonas;
        public virtual ICollection<Zona> Zonas { get; set; }
        #endregion
     
        #region Constructors
        public Mozo()
        {
            Zonas = new HashSet<Zona>();
        }
        #endregion
    }
}
