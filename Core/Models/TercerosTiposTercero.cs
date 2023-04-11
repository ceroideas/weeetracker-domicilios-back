using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosTiposTercero
    {
        public int PidTerceroTipoTercero { get; set; }
        public int SidTercero { get; set; }
        public int SidTipoTercero { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }

        public Terceros SidTerceroNavigation { get; set; }
        public TiposTercero SidTipoTerceroNavigation { get; set; }
    }
}
