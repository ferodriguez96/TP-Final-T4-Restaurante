using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Mesa
    {
        #region Properties
        public int Id { get; set; }
        public String descripcion { get; set; } //estas cosas son Properties
        public Zona zona { get; set; }
        public virtual IEnumerable<Reserva> Reservas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        #endregion

        #region Constructors
        Mesa()
        {
            Reservas = new HashSet<Reserva>();
            Pedidos = new HashSet<Pedido>();
        }
        #endregion
    }
}
