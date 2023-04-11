using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Incidencias
    {
        public string PidIncidencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int SidTipoIncidencia { get; set; }
        public int SidEstadoIncidencia { get; set; }
        public string SidCertificado { get; set; }
        public string SidRaee { get; set; }
        public DateTime? FechaCambioEstado { get; set; }
        public int? SidTercero { get; set; }

        public Certificados SidCertificadoNavigation { get; set; }
    }
}
