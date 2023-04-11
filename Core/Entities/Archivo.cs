using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeeTrackerAPI.Common;

namespace WeeeTrackerAPI.Entities
{
    public class Archivo
    {
        public string ArchivoCodificado { get; set; }
        public string Nombre { get; set; }
        public TipoArchivo Tipo { get; set; }
    }
}
