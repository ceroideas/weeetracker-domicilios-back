using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ObservacionesRaee
    {
        public int PidObservacionRaee { get; set; }
        public DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public string SidRaee { get; set; }
        public int SidUsuario { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
