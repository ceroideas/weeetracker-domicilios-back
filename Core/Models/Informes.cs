using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Informes
    {
        public int PidInforme { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string Server { get; set; }
        public string Ruta { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int? Tipo { get; set; }
    }
}
