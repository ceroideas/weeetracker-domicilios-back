using System.Collections.Generic;
using System.Linq;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IStock
    {
        Stock GetStock(int idTercero, int idCentro);
        object StockUsuario(int idUsuario, int idCentro);
    }
}
