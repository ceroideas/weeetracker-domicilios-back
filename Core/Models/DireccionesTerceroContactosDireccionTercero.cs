using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class DireccionesTerceroContactosDireccionTercero
    {
        public int PidDireccionTerceroContactoDireccionTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public int SidContactoDireccionTercero { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }

        public ContactosDireccionTercero SidContactoDireccionTerceroNavigation { get; set; }
        public DireccionesTercero SidDireccionTerceroNavigation { get; set; }
    }
}
