using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Certificados
    {
        public Certificados()
        {
            HistoricoCambios = new HashSet<HistoricoCambios>();
            HistoricoCambiosCertificados = new HashSet<HistoricoCambiosCertificados>();
            HistoricoPesosRaee = new HashSet<HistoricoPesosRaee>();
            Incidencias = new HashSet<Incidencias>();
            Pesadas = new HashSet<Pesadas>();
            RaeesAlbaranesEcotrazo = new HashSet<RaeesAlbaranesEcotrazo>();
            RaeesCertificados = new HashSet<RaeesCertificados>();
        }

        public string PidCertificado { get; set; }
        public int SidTipoCertificado { get; set; }
        public int SidSig { get; set; }
        public string NroCertificadoReferencia { get; set; }
        public string NroCertificado { get; set; }
        public DateTime Fecha { get; set; }
        public int? SidSolicitud { get; set; }
        public int? SidTerceroSolicitante { get; set; }
        public int? SidDireccionTerceroSolicitante { get; set; }
        public string AuxEntidad { get; set; }
        public string AuxReferencia { get; set; }
        public string AuxNif { get; set; }
        public string AuxDireccion { get; set; }
        public string AuxLocalidad { get; set; }
        public string AuxProvincia { get; set; }
        public string AuxTelefono { get; set; }
        public string TransportistaCodigo { get; set; }
        public string TransportistaDocControl { get; set; }
        public string TransportistaNombre { get; set; }
        public string TransportistaNif { get; set; }
        public string TransportistaExpedicion { get; set; }
        public string TransportistaMatricula { get; set; }
        public string TransportistaConductor { get; set; }
        public string TransportistaDni { get; set; }
        public int SidTerceroDestinatario { get; set; }
        public int SidDireccionTerceroDestinatario { get; set; }
        public int SidEstadoCertificado { get; set; }
        public string SidFirmaProcedencia { get; set; }
        public string SidFirmaTransporte { get; set; }
        public string SidFirmaDestino { get; set; }
        public string Observaciones { get; set; }
        public string AuxPais { get; set; }
        public int SidTerceroEmisor { get; set; }
        public int? SidDireccionTerceroEmisor { get; set; }
        public int? NumRaees { get; set; }
        public float? PesoEnviado { get; set; }
        public DateTime? UltimaActualizacion { get; set; }
        public DateTime? Completado { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public int? Servicio { get; set; }
        public string Email { get; set; }
        public int? NumFirmas { get; set; }
        public string NumCertOrigen { get; set; }

        public TiposServicio ServicioNavigation { get; set; }
        public DireccionesTercero SidDireccionTerceroDestinatarioNavigation { get; set; }
        public DireccionesTercero SidDireccionTerceroSolicitanteNavigation { get; set; }
        public EstadosCertificado SidEstadoCertificadoNavigation { get; set; }
        public FirmasCertificado SidFirmaDestinoNavigation { get; set; }
        public FirmasCertificado SidFirmaProcedenciaNavigation { get; set; }
        public FirmasCertificado SidFirmaTransporteNavigation { get; set; }
        public Sigs SidSigNavigation { get; set; }
        public Terceros SidTerceroEmisorNavigation { get; set; }
        public TiposCertificado SidTipoCertificadoNavigation { get; set; }
        public ICollection<HistoricoCambios> HistoricoCambios { get; set; }
        public ICollection<HistoricoCambiosCertificados> HistoricoCambiosCertificados { get; set; }
        public ICollection<HistoricoPesosRaee> HistoricoPesosRaee { get; set; }
        public ICollection<Incidencias> Incidencias { get; set; }
        public ICollection<Pesadas> Pesadas { get; set; }
        public ICollection<RaeesAlbaranesEcotrazo> RaeesAlbaranesEcotrazo { get; set; }
        public ICollection<RaeesCertificados> RaeesCertificados { get; set; }
    }
}
