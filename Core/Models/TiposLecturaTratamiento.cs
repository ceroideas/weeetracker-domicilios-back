using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposLecturaTratamiento
    {
        public TiposLecturaTratamiento()
        {
            CertificadosTratamiento = new HashSet<CertificadosTratamiento>();
        }

        public int PidTipoLecturaTratamiento { get; set; }
        public string Nombre { get; set; }

        public ICollection<CertificadosTratamiento> CertificadosTratamiento { get; set; }
    }
}
