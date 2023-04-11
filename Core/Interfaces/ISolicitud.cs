using System;
using System.Linq;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using ServiceEcoapp;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface ISolicitud
    {
        Task<XElement> GetSolicitudes(SolicitudFiltros solicitud);
        Task<XMLRecepcionSolicitudesResponse> AltaSolicitudAsync(Entities.Solicitudes solicitudes);
        Task<CambioFechaEstimadaResponse> ValidacionSolicitud(SolicitudValidacion solicitud);
        Entities.Solicitudes SetDatosSolicitudesAlta(int idUsuario, SolicitudFiltros solicitud);
        List<SolicitudConsulta> SetDatosSolicitudConsulta(string xml);
    }

    public interface ISolicitudConsulta
    {
        string cod { get; set; }
        string descripcion { get; set; }
        string fechaSolicitud { get; set; }
        string fechaAnulacion { get; set; }
        string fechaRecogida { get; set; }
        string albaranOrigen { get; set; }
        string nombreTerceroAsignado { get; set; }
        linea[] linea { get; set; }
        string observaciones { get; set; }
        string est { get; set; }
    }

    public interface ISolicitudAlta
    {
        Solicitud solicitud { get; set; }
    }

    public interface ISolicitudValidacion
    {
        string codSolicitud { get; set; }
        string fechaRec { get; set; }
    }

}
