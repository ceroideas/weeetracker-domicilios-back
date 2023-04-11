using Microsoft.Extensions.Configuration;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IRaee
    {
        string AltaResiduo(int idUsuario, Residuo residuo);
        bool AltaEstado(int idUsuario, Residuo residuo);
        bool ActualizaResiduo(Residuo residuo);
        object ExisteRaee(string idRaee);
        object GetRaeesResiduoEspecifico(Residuo residuo);
        object GetRaeesResiduoEspecificoUsuario(int idUsuario, int idCentro, int idResiduo);
        object GetRaeesAlbaran(Residuo residuo);
    }
}
