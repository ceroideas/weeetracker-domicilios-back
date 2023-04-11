using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoCambios
    {
        public int PidHistoricoCambio { get; set; }
        public DateTime? Fecha { get; set; }
        public string SidCertificado { get; set; }
        public int? SidResiduoEspecificoAntes { get; set; }
        public int? SidResiduoEspecificoDespues { get; set; }
        public int? SidTipoDeContenedorAntes { get; set; }
        public int? SidTipoDeContenedorDespues { get; set; }
        public bool? CanibalizadoAntes { get; set; }
        public bool? CanibalizadoDespues { get; set; }
        public int? SidEstadoAntes { get; set; }
        public int? SidEstadoDespues { get; set; }
        public string SidRaee { get; set; }
        public string SidRaeecertificado { get; set; }

        public Certificados SidCertificadoNavigation { get; set; }
        public EstadosRaee SidEstadoAntesNavigation { get; set; }
        public EstadosRaee SidEstadoDespuesNavigation { get; set; }
        public Raees SidRaeeNavigation { get; set; }
        public ResiduosEspecificos SidResiduoEspecificoAntesNavigation { get; set; }
        public ResiduosEspecificos SidResiduoEspecificoDespuesNavigation { get; set; }
        public TiposContenedor SidTipoDeContenedorAntesNavigation { get; set; }
        public TiposContenedor SidTipoDeContenedorDespuesNavigation { get; set; }
    }
}
