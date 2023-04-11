using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Solicitudes
    {
        public int PidSolicitud { get; set; }
        public DateTime Fecha { get; set; }
        public int SidTerceroOrigen { get; set; }
        public int SidTerceroDestino { get; set; }
        public int SidDireccionTerceroOrigen { get; set; }
        public int? SidDireccionTerceroDestino { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string Accion { get; set; }
        public int Estado { get; set; }
        public string Observaciones { get; set; }
        public Guid Rowguid { get; set; }
        public string AlbaranOrigen { get; set; }

        public DireccionesTercero SidDireccionTerceroDestinoNavigation { get; set; }
        public DireccionesTercero SidDireccionTerceroOrigenNavigation { get; set; }
        public Terceros SidTerceroDestinoNavigation { get; set; }
        public Terceros SidTerceroOrigenNavigation { get; set; }
    }
}
