using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ResiduosEspecificos
    {
        public ResiduosEspecificos()
        {
            HistoricoCambiosSidResiduoEspecificoAntesNavigation = new HashSet<HistoricoCambios>();
            HistoricoCambiosSidResiduoEspecificoDespuesNavigation = new HashSet<HistoricoCambios>();
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
        }

        public int PidResiduoEspecifico { get; set; }
        public string Nombre { get; set; }
        public float? PesoEstimado { get; set; }
        public int Estado { get; set; }
        public int? SidResiduo { get; set; }
        public int? SidFraccion { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public Fracciones SidFraccionNavigation { get; set; }
        public Residuos SidResiduoNavigation { get; set; }
        public ICollection<HistoricoCambios> HistoricoCambiosSidResiduoEspecificoAntesNavigation { get; set; }
        public ICollection<HistoricoCambios> HistoricoCambiosSidResiduoEspecificoDespuesNavigation { get; set; }
        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
    }
}
