using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Permisos
    {
        public Permisos()
        {
            RolesPermisos = new HashSet<RolesPermisos>();
        }

        public int PidPermiso { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public ICollection<RolesPermisos> RolesPermisos { get; set; }
    }
}
