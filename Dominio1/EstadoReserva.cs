using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class EstadoReserva
    {
        #region Properties
        public int Id { get; set; }
        public String descripcion { get; set; }
        public virtual IEnumerable<Reserva> Reservas { get; set; }
        #endregion

        #region Constructors
        EstadoReserva()
        {
            Reservas = new HashSet<Reserva>();
        }
        #endregion
    }
}
