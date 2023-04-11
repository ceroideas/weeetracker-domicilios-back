using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Paises
    {
        public Paises()
        {
            DireccionesTercero = new HashSet<DireccionesTercero>();
            Provincias = new HashSet<Provincias>();
        }

        public int PidPais { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public string Codigo { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public ICollection<DireccionesTercero> DireccionesTercero { get; set; }
        public ICollection<Provincias> Provincias { get; set; }
    }
}
