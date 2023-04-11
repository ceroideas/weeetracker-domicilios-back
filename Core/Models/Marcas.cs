using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Marcas
    {
        public int PidMarca { get; set; }
        public string Nombre { get; set; }
        public bool Activa { get; set; }
        public Guid Rowguid { get; set; }
    }
}
