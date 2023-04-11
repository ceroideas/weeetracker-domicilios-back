using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class InventariosFisicosRaees
    {
        public string PidInventarioFisicoRaee { get; set; }
        public string SidInventarioFisico { get; set; }
        public string SidRaee { get; set; }
        public Guid Rowguid { get; set; }

        public InventariosFisicos SidInventarioFisicoNavigation { get; set; }
    }
}
