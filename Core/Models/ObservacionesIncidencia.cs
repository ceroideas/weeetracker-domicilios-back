using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ObservacionesIncidencia
    {
        public int PidObservacionIncidencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public string SidIncidencia { get; set; }
        public int SidUsuario { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
