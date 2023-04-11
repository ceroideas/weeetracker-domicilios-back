using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IResiduoEspecifico
    {
        object getResiduos();
        ResiduosEspecificos getResiduoEspecificoById(int idResiduoEspecifico);
    }
}
