using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AsignacionesEntrega
    {
        public int PidAsignacionEntrega { get; set; }
        public int SidTerceroOrigen { get; set; }
        public int SidDireccionTerceroOrigen { get; set; }
        public int? SidFraccionOrigen { get; set; }
        public int SidTerceroDestino { get; set; }
        public int? SidDireccionTerceroDestino { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }
    }
}
