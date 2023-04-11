using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{

    public class TiposContenedorService : ITiposContenedor
    {
        private GVRBD3Context _context;

        public TiposContenedorService(GVRBD3Context context)
        {
            this._context = context;
        }

       
        public TiposContenedor getTipoContenedorById(int idTipoCont)
        {
            try
            {
                TiposContenedor tipoContenedor = _context.TiposContenedor
                    .Where(r=>r.PidTipoContenedor == idTipoCont)
                    .Select(item => new TiposContenedor
                    {
                        PidTipoContenedor = item.PidTipoContenedor,
                        Nombre = item.Nombre
                    })
                    .FirstOrDefault();

                return tipoContenedor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}