using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Sigs
    {
        public Sigs()
        {
            Certificados = new HashSet<Certificados>();
        }

        public int PidSig { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

        public ICollection<Certificados> Certificados { get; set; }
    }
}
