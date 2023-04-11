using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ParametrosGlobales
    {
        public int PidParametroGlobal { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }
    }
}
