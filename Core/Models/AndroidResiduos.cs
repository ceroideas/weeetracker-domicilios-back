using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidResiduos
    {
        public int PidResiduoAndroid { get; set; }
        public string Nombre { get; set; }
        public int SidFraccion { get; set; }
        public int SidResiduo { get; set; }
        public int SidResiduoEspecifico { get; set; }
        public float PesoUnitario { get; set; }
        public int? Orden { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Activo { get; set; }
        public int? SidTercero { get; set; }
    }
}
