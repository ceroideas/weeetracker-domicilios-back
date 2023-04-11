using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class InventariosFisicos
    {
        public InventariosFisicos()
        {
            InventariosFisicosRaees = new HashSet<InventariosFisicosRaees>();
        }

        public string PidInventarioFisico { get; set; }
        public DateTime Fecha { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public bool Auditor { get; set; }

        public DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
        public ICollection<InventariosFisicosRaees> InventariosFisicosRaees { get; set; }
    }
}
