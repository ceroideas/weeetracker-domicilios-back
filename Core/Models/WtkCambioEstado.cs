using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkCambioEstado
    {
        public WtkCambioEstado()
        {
            WtkCambioEstadoFirma = new HashSet<WtkCambioEstadoFirma>();
            WtkCambioEstadoFotografia = new HashSet<WtkCambioEstadoFotografia>();
        }

        public int Id { get; set; }
        public string SidRaee { get; set; }
        public int SidEstado { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public int? SidUsuario { get; set; }
        public double? GpsX { get; set; }
        public double? GpsY { get; set; }
        public double? GpsZ { get; set; }
        public string Albaran { get; set; }
        public string Dni { get; set; }
        public DateTime Fecha { get; set; }

        public DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public EstadosRaee SidEstadoNavigation { get; set; }
        public Raees SidRaeeNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
        public WtkUsuario SidUsuarioNavigation { get; set; }
        public ICollection<WtkCambioEstadoFirma> WtkCambioEstadoFirma { get; set; }
        public ICollection<WtkCambioEstadoFotografia> WtkCambioEstadoFotografia { get; set; }
    }
}
