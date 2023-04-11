using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AuxProcesarAutorizaciones
    {
        public int PidAutorizacion { get; set; }
        public int SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int Operacion { get; set; }
        public int? SidFraccion { get; set; }
    }
}
