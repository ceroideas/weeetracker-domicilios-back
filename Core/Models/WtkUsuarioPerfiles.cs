using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkUsuarioPerfiles
    {
        public int SidUsuario { get; set; }
        public string SidPerfil { get; set; }

        public WtkPerfil SidPerfilNavigation { get; set; }
        public WtkUsuario SidUsuarioNavigation { get; set; }
    }
}
