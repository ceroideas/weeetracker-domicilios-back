using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ControlEtiquetasRemesas
    {
        public int PidRemesa { get; set; }
        public int? TotEntregados { get; set; }
        public int? TotPerdidos { get; set; }
        public int? TotConsumidos { get; set; }
    }
}
