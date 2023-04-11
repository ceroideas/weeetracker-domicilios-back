using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkTextoLopd
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int SidTercero { get; set; }

        public Terceros SidTerceroNavigation { get; set; }
    }
}
