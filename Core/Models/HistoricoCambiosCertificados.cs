using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoCambiosCertificados
    {
        public int PidHistoricoCambioCertificado { get; set; }
        public DateTime? Fecha { get; set; }
        public string SidCertificado { get; set; }
        public int? SidEstadoAntes { get; set; }
        public int? SidEstadoDespues { get; set; }

        public Certificados SidCertificadoNavigation { get; set; }
        public EstadosCertificado SidEstadoAntesNavigation { get; set; }
        public EstadosCertificado SidEstadoDespuesNavigation { get; set; }
    }
}
