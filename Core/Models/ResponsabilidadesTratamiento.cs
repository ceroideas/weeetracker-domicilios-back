using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ResponsabilidadesTratamiento
    {
        public int Id { get; set; }
        public int PidResponsabilidadTratamiento { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public string TipoOperacion { get; set; }
        public int SidFraccion { get; set; }
        public int SidResiduo { get; set; }
        public int? SidTipoContenedor { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }
    }
}
