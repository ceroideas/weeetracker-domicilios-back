using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Entities
{
    
    public class SolicitudConsulta : ISolicitudConsulta
    {
        public string cod { get; set; }
        public string descripcion { get; set; }
        public string fechaSolicitud { get; set; }
        public string fechaAnulacion { get; set; }
        public string fechaRecogida { get; set; }
        public string albaranOrigen { get; set; }
        public string nombreTerceroAsignado { get; set; }
        public linea[] linea { get; set; }
        public string observaciones { get; set; }
        public string est { get; set; }
    }
}