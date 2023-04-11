using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{

    public class TerceroService : ITercero
    {
        private GVRBD3Context _context;

        public TerceroService(GVRBD3Context context)
        {
            this._context = context;
        }

        public object getTercero(WtkUsuario usuario)
        {
            try
            {
                var tercero = _context.Terceros
                    .Where(t => t.PidTercero == usuario.SidTercero)
                    .Select(item => new
                    {
                        item.PidTercero,
                        item.Nombre,
                        item.WtkTextoLopd
                    })
                    .FirstOrDefault();

                return tercero;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}