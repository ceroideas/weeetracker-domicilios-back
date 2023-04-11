using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class RolesPermisos
    {
        public int SidPermiso { get; set; }
        public int SidRol { get; set; }

        public Permisos SidPermisoNavigation { get; set; }
        public Roles SidRolNavigation { get; set; }
    }
}
