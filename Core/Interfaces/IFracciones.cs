using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IFracciones
    {
        Fracciones getFraccionById(int idFraccion);
    }
}
