using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Residuos
    {
        public Residuos()
        {
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
            ResiduosEspecificos = new HashSet<ResiduosEspecificos>();
        }

        public int PidResiduo { get; set; }
        public int SidFraccion { get; set; }
        public int Estado { get; set; }
        public string Nombre { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public Fracciones SidFraccionNavigation { get; set; }
        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
        public ICollection<ResiduosEspecificos> ResiduosEspecificos { get; set; }
    }
}
