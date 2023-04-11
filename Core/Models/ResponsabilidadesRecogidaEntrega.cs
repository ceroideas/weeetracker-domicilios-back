using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ResponsabilidadesRecogidaEntrega
    {
        public int Id { get; set; }
        public int PidResponsabilidadRecogidaEntrega { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public string TipoOperacion { get; set; }
        public int SidFraccion { get; set; }
        public int? SidTipoContenedor { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }
    }
}
