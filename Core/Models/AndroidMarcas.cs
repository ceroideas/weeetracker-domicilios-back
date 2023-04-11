using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidMarcas
    {
        public int PidMarca { get; set; }
        public string Nombre { get; set; }
        public bool? Activa { get; set; }
        public int? SidTercero { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
