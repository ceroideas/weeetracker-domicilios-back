using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidServiciosSinRetirada
    {
        public string PidCertificado { get; set; }
        public string NroCertificadoReferencia { get; set; }
        public DateTime Fecha { get; set; }
        public int? SidTerceroSolicitante { get; set; }
        public int? SidDireccionTerceroSolicitante { get; set; }
        public int SidTerceroDestinatario { get; set; }
        public int SidDireccionTerceroDestinatario { get; set; }
        public int SidEstadoCertificado { get; set; }
        public string SidFirmaProcedencia { get; set; }
        public int SidTerceroEmisor { get; set; }
        public int? SidDireccionTerceroEmisor { get; set; }
        public int? Servicio { get; set; }
        public string Email { get; set; }
        public double? GpsX { get; set; }
        public double? GpsY { get; set; }
        public double? GpsZ { get; set; }
        public int NumFirmas { get; set; }
        public string SidFirmaTransporte { get; set; }
        public string NumCertOrigen { get; set; }
    }
}
