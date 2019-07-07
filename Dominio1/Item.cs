using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Item
    {
        #region Properties
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public String Nombre { get; set; }
        public float Precio { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        //Stock
        #endregion
        
        #region Constructors
        public Item()
        {
            Pedidos = new HashSet<Pedido>();
        }
        #endregion
    }
}
