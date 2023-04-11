using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Usuarios
    {
        public int PidUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public bool Activo { get; set; }
        public int SidRol { get; set; }
        public int SidEstado { get; set; }
        public int? Intento { get; set; }
        public DateTime? Caduca { get; set; }

        public Roles SidRolNavigation { get; set; }
    }
}
