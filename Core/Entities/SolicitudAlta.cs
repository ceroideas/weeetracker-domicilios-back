using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Entities
{
    public class Solicitudes : ISolicitudAlta
    {
        public Solicitud solicitud { get; set; }
    }

    public class Solicitud
    {
        public DateTime fecha { get; set; }
        public string codigoExt { get; set; }
        public string albaranOrigen { get; set; }
        public int terceroOri { get; set; }
        public int tipoTerceroOri { get; set; }
        public int direOri { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
        public linea[] lineas { get; set; }
        public string codigo { get; set; }
        public string error { get; set; }
    }

    public class linea
    {
        public int frac { get; set; }
        public string fracNombre { get; set; }
        public int res { get; set; }
        public string resNombre { get; set; }
        public int resEspe { get; set; }
        public string resEspeNombre { get; set; }
        public int tipoCont { get; set; }
        public string tipoContNombre { get; set; }
        public int uni { get; set; }
        public int kil { get; set; }
        public string observaciones { get; set; }
    }

    //-----------------------------------------------------------------------------------

}