using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Remesas
    {
        public int PidRemesa { get; set; }
        public int SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string CodigoInicioRango { get; set; }
        public string CodigoFinRango { get; set; }
        public string CodigoInicioTratado { get; set; }
        public string CodigoFinTratado { get; set; }
        public int SidEstadoRemesa { get; set; }
        public string ReferenciaRemesa { get; set; }
        public string ReferenciaProducto { get; set; }

        public DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public EstadosRemesa SidEstadoRemesaNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
    }
}
