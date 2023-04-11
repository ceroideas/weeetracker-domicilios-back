using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class V3v2ProcTablasBorrar
    {
        public int Id { get; set; }
        public string Tabla { get; set; }
        public int Borrar { get; set; }
        public string TipoDatos { get; set; }
        public int? OrdenBorrado { get; set; }
    }
}
