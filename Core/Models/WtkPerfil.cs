using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkPerfil
    {
        public WtkPerfil()
        {
            WtkUsuarioPerfiles = new HashSet<WtkUsuarioPerfiles>();
        }

        public string Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<WtkUsuarioPerfiles> WtkUsuarioPerfiles { get; set; }
    }
}
