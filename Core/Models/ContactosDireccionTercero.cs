using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ContactosDireccionTercero
    {
        public ContactosDireccionTercero()
        {
            DireccionesTerceroContactosDireccionTercero = new HashSet<DireccionesTerceroContactosDireccionTercero>();
        }

        public int PidContactoDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contrasena { get; set; }
        public int Estado { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int? SidTercero { get; set; }
        public int? CodGtr { get; set; }
        public bool? PerfilGvr { get; set; }
        public Guid Rowguid { get; set; }

        public Terceros SidTerceroNavigation { get; set; }
        public ICollection<DireccionesTerceroContactosDireccionTercero> DireccionesTerceroContactosDireccionTercero { get; set; }
    }
}
