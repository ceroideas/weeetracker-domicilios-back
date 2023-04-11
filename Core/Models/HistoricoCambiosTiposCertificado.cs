using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoCambiosTiposCertificado
    {
        public int PidCambioTipoCertificado { get; set; }
        public string AnteriorCertificado { get; set; }
        public string NuevoCertificado { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
