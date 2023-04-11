using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkUsuarioDirecciones
    {
        public int SidUsuario { get; set; }
        public int SidDireccion { get; set; }

        public DireccionesTercero SidDireccionNavigation { get; set; }
        public WtkUsuario SidUsuarioNavigation { get; set; }
    }
}
