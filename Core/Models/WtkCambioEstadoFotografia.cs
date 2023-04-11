using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkCambioEstadoFotografia
    {
        public int Id { get; set; }
        public int? SidCambioEstado { get; set; }
        public string Fichero { get; set; }

        public WtkCambioEstado SidCambioEstadoNavigation { get; set; }
    }
}
