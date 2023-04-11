using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class DireccionesTerceroTiposTercero
    {
        public int PidDireccionTerceroTipoTercero { get; set; }
        public int SidDireccionesTercero { get; set; }
        public int SidTipoTercero { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }

        public DireccionesTercero SidDireccionesTerceroNavigation { get; set; }
        public TiposTercero SidTipoTerceroNavigation { get; set; }
    }
}
