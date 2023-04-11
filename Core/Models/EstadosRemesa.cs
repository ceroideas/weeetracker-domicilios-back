using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class EstadosRemesa
    {
        public EstadosRemesa()
        {
            Remesas = new HashSet<Remesas>();
        }

        public int PidEstadoRemesa { get; set; }
        public string Nombre { get; set; }

        public ICollection<Remesas> Remesas { get; set; }
    }
}
