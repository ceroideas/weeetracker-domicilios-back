using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class LogEventoPortal
    {
        public int PidLogEventoPortal { get; set; }
        public string EntidadAfectada { get; set; }
        public string Proceso { get; set; }
        public string Detalles { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
