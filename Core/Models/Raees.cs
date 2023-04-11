using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Raees
    {
        public Raees()
        {
            HistoricoCambios = new HashSet<HistoricoCambios>();
            HistoricoPesosRaee = new HashSet<HistoricoPesosRaee>();
            RaeesAlbaranesEcotrazo = new HashSet<RaeesAlbaranesEcotrazo>();
            RaeesCertificados = new HashSet<RaeesCertificados>();
            WtkCambioEstado = new HashSet<WtkCambioEstado>();
        }

        public string PidRaee { get; set; }
        public int SidSig { get; set; }
        public int SidTipoEtiqueta { get; set; }
        public int SidResiduoEspecifico { get; set; }
        public int SidTipoContenedor { get; set; }
        public float? PesoEstimado { get; set; }
        public float? PesoReal { get; set; }
        public bool Canibalizado { get; set; }
        public int SidEstadoRaee { get; set; }
        public int? SidCertificadoTratamiento { get; set; }
        public int SidFraccion { get; set; }
        public int SidPaisCodigoRaee { get; set; }
        public int? SidMarca { get; set; }
        public float? DiasVida { get; set; }
        public float? DistanciaHastaTratamiento { get; set; }
        public float? DistanciaHastaTratamientoTramos { get; set; }
        public int Estado { get; set; }
        public int? SidResiduo { get; set; }
        public string CodigoRefTercero { get; set; }
        public int? Destino { get; set; }
        public string Serie { get; set; }
        public Guid Rowguid { get; set; }

        public TiposDestino DestinoNavigation { get; set; }
        public CertificadosTratamiento SidCertificadoTratamientoNavigation { get; set; }
        public EstadosRaee SidEstadoRaeeNavigation { get; set; }
        public Fracciones SidFraccionNavigation { get; set; }
        public ResiduosEspecificos SidResiduoEspecificoNavigation { get; set; }
        public Residuos SidResiduoNavigation { get; set; }
        public TiposContenedor SidTipoContenedorNavigation { get; set; }
        public ICollection<HistoricoCambios> HistoricoCambios { get; set; }
        public ICollection<HistoricoPesosRaee> HistoricoPesosRaee { get; set; }
        public ICollection<RaeesAlbaranesEcotrazo> RaeesAlbaranesEcotrazo { get; set; }
        public ICollection<RaeesCertificados> RaeesCertificados { get; set; }
        public ICollection<WtkCambioEstado> WtkCambioEstado { get; set; }

        public static implicit operator Raees(List<Raees> v)
        {
            throw new NotImplementedException();
        }
    }
}
