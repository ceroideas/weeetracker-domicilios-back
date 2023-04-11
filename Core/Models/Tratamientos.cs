using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Tratamientos
    {
        public string PidTratamiento { get; set; }
        public DateTime Fecha { get; set; }
        public int CodTercero { get; set; }
        public int CodDirTercero { get; set; }
        public int CodInstalaTratamiento { get; set; }
        public bool GrabaVideo { get; set; }
        public string Etiquetas { get; set; }
        public string Rfids { get; set; }
        public string NroCertificado { get; set; }
    }
}
