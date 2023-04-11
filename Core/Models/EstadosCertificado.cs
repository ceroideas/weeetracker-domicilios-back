using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class EstadosCertificado
    {
        public EstadosCertificado()
        {
            Certificados = new HashSet<Certificados>();
            HistoricoCambiosCertificadosSidEstadoAntesNavigation = new HashSet<HistoricoCambiosCertificados>();
            HistoricoCambiosCertificadosSidEstadoDespuesNavigation = new HashSet<HistoricoCambiosCertificados>();
        }

        public int PidEstadoCertificado { get; set; }
        public string Nombre { get; set; }

        public ICollection<Certificados> Certificados { get; set; }
        public ICollection<HistoricoCambiosCertificados> HistoricoCambiosCertificadosSidEstadoAntesNavigation { get; set; }
        public ICollection<HistoricoCambiosCertificados> HistoricoCambiosCertificadosSidEstadoDespuesNavigation { get; set; }
    }
}
