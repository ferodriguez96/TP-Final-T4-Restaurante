using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class EstadoPedido
    {
        #region Properties
        public int Id { get; set; }
        public String descripcion { get; set; }
        public virtual IEnumerable<Pedido> Pedidos { get; set; }
        #endregion

        #region Constructors
        EstadoPedido()
        {
            Pedidos = new HashSet<Pedido>();
        }
        #endregion
    }
}
