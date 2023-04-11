using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class VersionesPda
    {
        public string NumPda { get; set; }
        public string NombrePrograma { get; set; }
        public string Version { get; set; }
        public DateTime? FechaBloqueo { get; set; }
        public string TextoBloqueo { get; set; }
        public string Bd { get; set; }
        public string PublicacionMaestros { get; set; }
        public string PublicacionRaees { get; set; }
        public string PublicacionInventario { get; set; }
    }
}
