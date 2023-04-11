using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{

    public class FraccionService : IFracciones
    {
        private GVRBD3Context _context;

        public FraccionService(GVRBD3Context context)
        {
            this._context = context;
        }

       
        public Fracciones getFraccionById(int idFraccion)
        {
            try
            {
                Fracciones fraccion = _context.Fracciones
                    .Where(r=>r.PidFraccion == idFraccion)
                    .Select(item => new Fracciones
                    {
                        PidFraccion = item.PidFraccion,
                        Nombre = item.Nombre
                    })
                    .FirstOrDefault();

                return fraccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}