using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class CertificadosTratamientoOk
    {
        public int PidCertificadoTratamiento { get; set; }
        public int SidTercero { get; set; }
        public DateTime FechaTratamiento { get; set; }
        public int SidDireccionTercero { get; set; }
        public int SidTipoLecturaTratamiento { get; set; }
        public int CodigoInstalacionTratamiento { get; set; }
        public bool GrabacionVideo { get; set; }
        public bool? Incidencia { get; set; }
        public string ObservacionesIncidencia { get; set; }
        public bool? Forzado { get; set; }
    }
}
