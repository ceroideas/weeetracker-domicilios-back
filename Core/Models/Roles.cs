using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RolesPermisos = new HashSet<RolesPermisos>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int PidRol { get; set; }
        public string Nombre { get; set; }

        public ICollection<RolesPermisos> RolesPermisos { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
