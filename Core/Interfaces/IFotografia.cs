using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IFotografia
    {
        WtkCambioEstadoFotografia GuardarFotografia(WtkCambioEstadoFotografia fotografia);
        WtkCambioEstadoFotografia SetDatosFotografia(string fichero, int sidCambioEstado);
        bool AltaFotografia(List<Archivo> listaImagenes, int idCambioEstado, string rutaLocal, string rutaServidor);
    }
}
