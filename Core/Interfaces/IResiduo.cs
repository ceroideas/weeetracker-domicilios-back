using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IResiduo
    {
        object getResiduos();
        Residuos getResiduoById(int idResiduo);
    }
}
