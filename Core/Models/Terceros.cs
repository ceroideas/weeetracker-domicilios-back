using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Terceros
    {
        public Terceros()
        {
            Certificados = new HashSet<Certificados>();
            CertificadosTratamiento = new HashSet<CertificadosTratamiento>();
            ContactosDireccionTercero = new HashSet<ContactosDireccionTercero>();
            DireccionesTercero = new HashSet<DireccionesTercero>();
            HistoricoPesadas = new HashSet<HistoricoPesadas>();
            InventariosFisicos = new HashSet<InventariosFisicos>();
            Pesadas = new HashSet<Pesadas>();
            Remesas = new HashSet<Remesas>();
            SolicitudesSidTerceroDestinoNavigation = new HashSet<Solicitudes>();
            SolicitudesSidTerceroOrigenNavigation = new HashSet<Solicitudes>();
            TercerosExcluidos = new HashSet<TercerosExcluidos>();
            TercerosReutilizacion2017 = new HashSet<TercerosReutilizacion2017>();
            TercerosTiposTercero = new HashSet<TercerosTiposTercero>();
            Terminales = new HashSet<Terminales>();
            WtkCambioEstado = new HashSet<WtkCambioEstado>();
            WtkUsuario = new HashSet<WtkUsuario>();
        }

        public int PidTercero { get; set; }
        public string Nombre { get; set; }
        public string Nif { get; set; }
        public int Estado { get; set; }
        public string NombreComercial { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public Terceros PidTerceroNavigation { get; set; }
        public Terceros InversePidTerceroNavigation { get; set; }
        public WtkTextoLopd WtkTextoLopd { get; set; }
        public ICollection<Certificados> Certificados { get; set; }
        public ICollection<CertificadosTratamiento> CertificadosTratamiento { get; set; }
        public ICollection<ContactosDireccionTercero> ContactosDireccionTercero { get; set; }
        public ICollection<DireccionesTercero> DireccionesTercero { get; set; }
        public ICollection<HistoricoPesadas> HistoricoPesadas { get; set; }
        public ICollection<InventariosFisicos> InventariosFisicos { get; set; }
        public ICollection<Pesadas> Pesadas { get; set; }
        public ICollection<Remesas> Remesas { get; set; }
        public ICollection<Solicitudes> SolicitudesSidTerceroDestinoNavigation { get; set; }
        public ICollection<Solicitudes> SolicitudesSidTerceroOrigenNavigation { get; set; }
        public ICollection<TercerosExcluidos> TercerosExcluidos { get; set; }
        public ICollection<TercerosReutilizacion2017> TercerosReutilizacion2017 { get; set; }
        public ICollection<TercerosTiposTercero> TercerosTiposTercero { get; set; }
        public ICollection<Terminales> Terminales { get; set; }
        public ICollection<WtkCambioEstado> WtkCambioEstado { get; set; }
        public ICollection<WtkUsuario> WtkUsuario { get; set; }
    }
}
