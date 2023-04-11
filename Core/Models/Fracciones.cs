using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Fracciones
    {
        public Fracciones()
        {
            HistoricoPesadas = new HashSet<HistoricoPesadas>();
            IndicadoresDireccionTerceroFraccion = new HashSet<IndicadoresDireccionTerceroFraccion>();
            Pesadas = new HashSet<Pesadas>();
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
            Residuos = new HashSet<Residuos>();
            ResiduosEspecificos = new HashSet<ResiduosEspecificos>();
        }

        public int PidFraccion { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }

        public ICollection<HistoricoPesadas> HistoricoPesadas { get; set; }
        public ICollection<IndicadoresDireccionTerceroFraccion> IndicadoresDireccionTerceroFraccion { get; set; }
        public ICollection<Pesadas> Pesadas { get; set; }
        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
        public ICollection<Residuos> Residuos { get; set; }
        public ICollection<ResiduosEspecificos> ResiduosEspecificos { get; set; }
    }
}
