using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Municipios
    {
        public Municipios()
        {
            DireccionesTercero = new HashSet<DireccionesTercero>();
        }

        public int PidMunicipio { get; set; }
        public string Nombre { get; set; }
        public int SidProvincia { get; set; }
        public int Estado { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public Provincias SidProvinciaNavigation { get; set; }
        public ICollection<DireccionesTercero> DireccionesTercero { get; set; }
    }
}
