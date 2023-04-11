using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoPesosRaee
    {
        public int PidHistorico { get; set; }
        public string SidRaee { get; set; }
        public string SidCertificado { get; set; }
        public DateTime Fecha { get; set; }
        public float Peso { get; set; }

        public Certificados SidCertificadoNavigation { get; set; }
        public Raees SidRaeeNavigation { get; set; }
    }
}
