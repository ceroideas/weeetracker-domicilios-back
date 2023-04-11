using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IFirma
    {
        WtkCambioEstadoFirma GuardarFirma(WtkCambioEstadoFirma firma);
        WtkCambioEstadoFirma SetDatosFirma(string nombre, string firma, int sidCambioEstado);
        bool AltaFirma(Residuo residuo, WtkCambioEstado cambioEstado, string rutaLocal, string rutaServidor);
    }
}
