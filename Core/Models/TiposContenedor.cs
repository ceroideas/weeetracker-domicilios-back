using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposContenedor
    {
        public TiposContenedor()
        {
            HistoricoCambiosSidTipoDeContenedorAntesNavigation = new HashSet<HistoricoCambios>();
            HistoricoCambiosSidTipoDeContenedorDespuesNavigation = new HashSet<HistoricoCambios>();
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
        }

        public int PidTipoContenedor { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public float? Tara { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public ICollection<HistoricoCambios> HistoricoCambiosSidTipoDeContenedorAntesNavigation { get; set; }
        public ICollection<HistoricoCambios> HistoricoCambiosSidTipoDeContenedorDespuesNavigation { get; set; }
        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
    }
}
