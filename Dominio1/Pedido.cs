using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pedido
    {
        #region Properties
        public int Id { get; set; }//Nro. Factura
        public DateTime feha { get; set; }
        public Mesa mesa { get; set; }
        public virtual ICollection<Item> Items { get; set; } 
        public EstadoPedido estadoPedido { get; set; }//Estado del pedido
        //Items tambien puede ser ===> public Item[] items; ===> pero yo hice una public virtual icollection<item> // ====>    hashset
        #endregion
        
        #region Constructors
        public Pedido()
        {
            Items = new HashSet<Item>();
        }
        #endregion
    }
}
