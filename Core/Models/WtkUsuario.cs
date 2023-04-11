using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkUsuario
    {
        public WtkUsuario()
        {
            WtkCambioEstado = new HashSet<WtkCambioEstado>();
            WtkUsuarioDirecciones = new HashSet<WtkUsuarioDirecciones>();
            WtkUsuarioPerfiles = new HashSet<WtkUsuarioPerfiles>();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int SidTercero { get; set; }
        public int SidTipoTercero { get; set; }
        public int Estado { get; set; }

        public Terceros SidTerceroNavigation { get; set; }
        public TiposTercero SidTipoTerceroNavigation { get; set; }
        public ICollection<WtkCambioEstado> WtkCambioEstado { get; set; }
        public ICollection<WtkUsuarioDirecciones> WtkUsuarioDirecciones { get; set; }
        public ICollection<WtkUsuarioPerfiles> WtkUsuarioPerfiles { get; set; }
    }
}
