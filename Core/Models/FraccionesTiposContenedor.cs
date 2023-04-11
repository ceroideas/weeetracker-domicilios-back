using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class FraccionesTiposContenedor
    {
        public int PidFraccionTipoContenedor { get; set; }
        public int SidFraccion { get; set; }
        public int SidTipoContenedor { get; set; }
        public float? PesoMedio { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }
    }
}
