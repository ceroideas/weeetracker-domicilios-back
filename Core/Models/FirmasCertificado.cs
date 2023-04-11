using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class FirmasCertificado
    {
        public FirmasCertificado()
        {
            CertificadosSidFirmaDestinoNavigation = new HashSet<Certificados>();
            CertificadosSidFirmaProcedenciaNavigation = new HashSet<Certificados>();
            CertificadosSidFirmaTransporteNavigation = new HashSet<Certificados>();
        }

        public string PidFirmaCertificado { get; set; }
        public string Firma { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public ICollection<Certificados> CertificadosSidFirmaDestinoNavigation { get; set; }
        public ICollection<Certificados> CertificadosSidFirmaProcedenciaNavigation { get; set; }
        public ICollection<Certificados> CertificadosSidFirmaTransporteNavigation { get; set; }
    }
}
