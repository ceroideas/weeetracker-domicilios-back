using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class EstadosRaee
    {
        public EstadosRaee()
        {
            HistoricoCambiosSidEstadoAntesNavigation = new HashSet<HistoricoCambios>();
            HistoricoCambiosSidEstadoDespuesNavigation = new HashSet<HistoricoCambios>();
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
            WtkCambioEstado = new HashSet<WtkCambioEstado>();
        }

        public int PidEstadoRaee { get; set; }
        public string Nombre { get; set; }
        public int? Orden { get; set; }

        public ICollection<HistoricoCambios> HistoricoCambiosSidEstadoAntesNavigation { get; set; }
        public ICollection<HistoricoCambios> HistoricoCambiosSidEstadoDespuesNavigation { get; set; }
        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
        public ICollection<WtkCambioEstado> WtkCambioEstado { get; set; }
    }
}
