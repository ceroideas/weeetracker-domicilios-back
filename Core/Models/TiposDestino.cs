using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposDestino
    {
        public TiposDestino()
        {
            Raees = new HashSet<Raees>();
            RaeesPruebas = new HashSet<RaeesPruebas>();
        }

        public int PidTipoDestino { get; set; }
        public string Nombre { get; set; }

        public ICollection<Raees> Raees { get; set; }
        public ICollection<RaeesPruebas> RaeesPruebas { get; set; }
    }
}
