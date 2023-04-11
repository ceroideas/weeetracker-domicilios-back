using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            DireccionesTercero = new HashSet<DireccionesTercero>();
            Municipios = new HashSet<Municipios>();
        }

        public int PidProvincia { get; set; }
        public string Nombre { get; set; }
        public int SidPais { get; set; }
        public int Estado { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public Paises SidPaisNavigation { get; set; }
        public ICollection<DireccionesTercero> DireccionesTercero { get; set; }
        public ICollection<Municipios> Municipios { get; set; }
    }
}
