using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class CertificadosTratamiento
    {
        public CertificadosTratamiento()
        {
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
        }

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
        public bool Reutilizacion { get; set; }

        public DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
        public TiposLecturaTratamiento SidTipoLecturaTratamientoNavigation { get; set; }
        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
    }
}
