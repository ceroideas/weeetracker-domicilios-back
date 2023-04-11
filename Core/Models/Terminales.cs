using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Terminales
    {
        public int SidTercero { get; set; }
        public int SidDireccion { get; set; }
        public string Terminal { get; set; }

        public DireccionesTercero SidDireccionNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
    }
}
