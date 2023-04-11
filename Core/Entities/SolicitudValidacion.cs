using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Entities
{
    public class SolicitudValidacion : ISolicitudValidacion
    {
        public string codSolicitud { get; set; }
        public string fechaRec { get; set; }
    }
}