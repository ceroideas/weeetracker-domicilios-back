using System;
using WeeeTrackerAPI.Common;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IEstado
    {

        WtkCambioEstado InsertEstado(WtkCambioEstado cambioEstado);
        int UpdateEstado(WtkCambioEstado cambioEstado);
        WtkCambioEstado SetDatosEstado(int idUsuario, string idRaee, Residuo residuo);
        WtkCambioEstado ExisteEntrada(string idRaee);
        WtkCambioEstado ExisteEntrada(string idRaee, int idCentro);
        WtkCambioEstado ExisteSalida(string idRaee);
    }
}
