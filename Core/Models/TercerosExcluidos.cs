using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosExcluidos
    {
        public int PidTerceroExcluido { get; set; }
        public int SidTercero { get; set; }

        public Terceros SidTerceroNavigation { get; set; }
    }
}
