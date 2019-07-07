using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Reserva
    {
        #region Properties
        public int Id { get; set; }
        public Mesa mesa { get; set; }
        public DateTime fecha_hora { get; set; }
        public String nombre;//a nombre de quien esta la reserva.
        public EstadoReserva estadoReserva { get; set; }
        #endregion
    }
}
