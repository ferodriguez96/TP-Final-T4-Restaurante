using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Categoria
    {
        #region Properties
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
        #endregion

        #region Constructors
        Categoria()
        {
            Items = new HashSet<Item>();
        }
        #endregion
    }
}
