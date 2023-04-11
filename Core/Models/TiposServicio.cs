using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposServicio
    {
        public TiposServicio()
        {
            Certificados = new HashSet<Certificados>();
        }

        public int PidTipoServicio { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public ICollection<Certificados> Certificados { get; set; }
    }
}
