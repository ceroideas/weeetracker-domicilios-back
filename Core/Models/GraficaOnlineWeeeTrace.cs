using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class GraficaOnlineWeeeTrace
    {
        public int PidGrafica { get; set; }
        public DateTime Fecha { get; set; }
        public float? PesoDia { get; set; }
        public long? PesoAcumulado { get; set; }
        public float? RaeesDia { get; set; }
        public long? RaeesAcumulado { get; set; }
    }
}
