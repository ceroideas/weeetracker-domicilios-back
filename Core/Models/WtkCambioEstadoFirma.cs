using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkCambioEstadoFirma
    {
        public int Id { get; set; }
        public int SidCambioEstado { get; set; }
        public string Firma { get; set; }
        public string Nombre { get; set; }

        public WtkCambioEstado SidCambioEstadoNavigation { get; set; }
    }
}
