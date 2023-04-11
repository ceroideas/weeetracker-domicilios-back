using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AccesosTemporalesGvr
    {
        public int AccesoId { get; set; }
        public string Usuario { get; set; }
        public string Codigoacceso { get; set; }
        public string Certificado { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Validez { get; set; }
        public string Pesada { get; set; }
    }
}
