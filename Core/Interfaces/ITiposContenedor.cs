using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface ITiposContenedor
    {
        TiposContenedor getTipoContenedorById(int idTipoCont);
    }
}
