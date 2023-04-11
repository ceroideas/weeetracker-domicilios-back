using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Common;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Entities
{
    public class SolicitudFiltros
    {
        public int idTercero { get; set; }
        public int idCentro { get; set; }
        public string Albaran { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public List<SolicitudResiduoEspecifico> ListaResiduosEspecificos { get; set; }
        public SolicitudFiltros()
        {
            ListaResiduosEspecificos = new List<SolicitudResiduoEspecifico>();
        }
    }
}