using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposTercero
    {
        public TiposTercero()
        {
            DireccionesTerceroTiposTercero = new HashSet<DireccionesTerceroTiposTercero>();
            TercerosTiposTercero = new HashSet<TercerosTiposTercero>();
            WtkUsuario = new HashSet<WtkUsuario>();
        }

        public int PidTipoTercero { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

        public ICollection<DireccionesTerceroTiposTercero> DireccionesTerceroTiposTercero { get; set; }
        public ICollection<TercerosTiposTercero> TercerosTiposTercero { get; set; }
        public ICollection<WtkUsuario> WtkUsuario { get; set; }
    }
}
