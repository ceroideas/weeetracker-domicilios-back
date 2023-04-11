using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class GraficaPortal
    {
        public int Pid { get; set; }
        public int Anyo { get; set; }
        public int Mes { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Recogidos { get; set; }
        public int? Tratados { get; set; }
        public int? NuevoCampo { get; set; }
    }
}
