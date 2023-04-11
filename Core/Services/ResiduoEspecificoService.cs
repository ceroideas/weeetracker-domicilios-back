using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{

    public class ResiduoEspecificoService : IResiduoEspecifico
    {
        private GVRBD3Context _context;

        public ResiduoEspecificoService(GVRBD3Context context)
        {
            this._context = context;
        }

        public object getResiduos()
        {
            try
            {
                var residuos = _context.WtkResiduoespecifico
                    .Select(item => new
                    {
                        item.Id,
                        item.Nombre,
                        item.Orden
                    })
                    .OrderBy(r => r.Orden)
                    .ToList();

                return residuos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public ResiduosEspecificos getResiduoEspecificoById(int idResiduoEspecifico)
        {
            try
            {
                ResiduosEspecificos residuo = _context.ResiduosEspecificos
                    .Where(r=>r.PidResiduoEspecifico == idResiduoEspecifico)
                    .Select(item => new ResiduosEspecificos
                    {
                        PesoEstimado = item.PesoEstimado,
                        Nombre = item.Nombre,
                        Estado = item.Estado,
                        SidResiduo = item.SidResiduo,
                        SidFraccion = item.SidFraccion
                    })
                    .FirstOrDefault();

                return residuo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}