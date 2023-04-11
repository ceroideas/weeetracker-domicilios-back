using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposOperativa
    {
        public string PidTipoOperativa { get; set; }
        public string NombreCodigo { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
    }
}
