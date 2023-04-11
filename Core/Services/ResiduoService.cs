using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{

    public class ResiduoService : IResiduo
    {
        private GVRBD3Context _context;

        public ResiduoService(GVRBD3Context context)
        {
            this._context = context;
        }

        public object getResiduos()
        {
            try
            {
                var residuos = _context.Residuos
                    .Select(item => new
                    {
                        item.PidResiduo,
                        item.Nombre                        
                    })
                    .OrderBy(r => r.Nombre)
                    .ToList();

                return residuos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Residuos getResiduoById(int idResiduo)
        {
            try
            {
                Residuos residuo = _context.Residuos
                    .Where(r=>r.PidResiduo == idResiduo)
                    .Select(item => new Residuos
                    {
                        PidResiduo = item.PidResiduo,
                        Nombre = item.Nombre
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