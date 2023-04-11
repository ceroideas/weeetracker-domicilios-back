using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class RaeesUltimaUbicacion
    {
        public string Raee { get; set; }
        public string Certificado { get; set; }
        public int? SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public DateTime? Fecha { get; set; }
        public string Video { get; set; }
    }
}
