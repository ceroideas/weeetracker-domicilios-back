using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidUsuarios
    {
        public int PidUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public int Uso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Activo { get; set; }
    }
}
