using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class RaeesCertificados
    {
        public string SidRaee { get; set; }
        public string SidCertificado { get; set; }
        public double? GpsX { get; set; }
        public double? GpsY { get; set; }
        public double? GpsZ { get; set; }
        public int SidTipoDeLectora { get; set; }
        public string PidRaeecertificado { get; set; }
        public double? DiasEnTerceros { get; set; }
        public float? Peso { get; set; }

        public Certificados SidCertificadoNavigation { get; set; }
        public Raees SidRaeeNavigation { get; set; }
    }
}
