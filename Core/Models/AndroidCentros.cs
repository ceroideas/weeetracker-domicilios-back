using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidCentros
    {
        public int PidDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public int SidTercero { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Activo { get; set; }
        public int? SidDireccionGenerica { get; set; }
    }
}
