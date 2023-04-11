using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class DireccionesTercero
    {
        public DireccionesTercero()
        {
            CertificadosSidDireccionTerceroDestinatarioNavigation = new HashSet<Certificados>();
            CertificadosSidDireccionTerceroSolicitanteNavigation = new HashSet<Certificados>();
            CertificadosTratamiento = new HashSet<CertificadosTratamiento>();
            DireccionesTerceroContactosDireccionTercero = new HashSet<DireccionesTerceroContactosDireccionTercero>();
            DireccionesTerceroTiposTercero = new HashSet<DireccionesTerceroTiposTercero>();
            HistoricoPesadas = new HashSet<HistoricoPesadas>();
            IndicadoresDireccionTerceroFraccion = new HashSet<IndicadoresDireccionTerceroFraccion>();
            InventariosFisicos = new HashSet<InventariosFisicos>();
            Pesadas = new HashSet<Pesadas>();
            Remesas = new HashSet<Remesas>();
            SolicitudesSidDireccionTerceroDestinoNavigation = new HashSet<Solicitudes>();
            SolicitudesSidDireccionTerceroOrigenNavigation = new HashSet<Solicitudes>();
            TercerosReutilizacion2017 = new HashSet<TercerosReutilizacion2017>();
            Terminales = new HashSet<Terminales>();
            WtkCambioEstado = new HashSet<WtkCambioEstado>();
            WtkUsuarioDirecciones = new HashSet<WtkUsuarioDirecciones>();
        }

        public int PidDireccionTercero { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public int SidProvincia { get; set; }
        public int SidPais { get; set; }
        public int SidTercero { get; set; }
        public int SidMunicipio { get; set; }
        public string CodigoPostal { get; set; }
        public int Estado { get; set; }
        public string TipoVia { get; set; }
        public double? CoordenadaX { get; set; }
        public double? CoordenadaY { get; set; }
        public int? CodGtr { get; set; }
        public int Pesado { get; set; }
        public int Inventario { get; set; }
        public int UsoRefTercero { get; set; }
        public int? CodTipo { get; set; }
        public string TipoDireccion { get; set; }
        public int? DiasPesado { get; set; }
        public Guid Rowguid { get; set; }

        public Municipios SidMunicipioNavigation { get; set; }
        public Paises SidPaisNavigation { get; set; }
        public Provincias SidProvinciaNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
        public ICollection<Certificados> CertificadosSidDireccionTerceroDestinatarioNavigation { get; set; }
        public ICollection<Certificados> CertificadosSidDireccionTerceroSolicitanteNavigation { get; set; }
        public ICollection<CertificadosTratamiento> CertificadosTratamiento { get; set; }
        public ICollection<DireccionesTerceroContactosDireccionTercero> DireccionesTerceroContactosDireccionTercero { get; set; }
        public ICollection<DireccionesTerceroTiposTercero> DireccionesTerceroTiposTercero { get; set; }
        public ICollection<HistoricoPesadas> HistoricoPesadas { get; set; }
        public ICollection<IndicadoresDireccionTerceroFraccion> IndicadoresDireccionTerceroFraccion { get; set; }
        public ICollection<InventariosFisicos> InventariosFisicos { get; set; }
        public ICollection<Pesadas> Pesadas { get; set; }
        public ICollection<Remesas> Remesas { get; set; }
        public ICollection<Solicitudes> SolicitudesSidDireccionTerceroDestinoNavigation { get; set; }
        public ICollection<Solicitudes> SolicitudesSidDireccionTerceroOrigenNavigation { get; set; }
        public ICollection<TercerosReutilizacion2017> TercerosReutilizacion2017 { get; set; }
        public ICollection<Terminales> Terminales { get; set; }
        public ICollection<WtkCambioEstado> WtkCambioEstado { get; set; }
        public ICollection<WtkUsuarioDirecciones> WtkUsuarioDirecciones { get; set; }
    }
}
