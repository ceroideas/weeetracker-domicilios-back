using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{
    public class CentroService: ICentro
    {
        private GVRBD3Context _context;

        public CentroService(GVRBD3Context context)
        {
            this._context = context;
        }

        public object getCentros(WtkUsuario usuario)
        {
            try
            {
                var direcciones = _context.DireccionesTercero
                    .Where(d => d.WtkUsuarioDirecciones
                    .Any(u => u.SidUsuario == usuario.Id))
                    .Select(item => new
                    {
                        item.PidDireccionTercero,
                        item.Nombre
                    })
                    .OrderBy(d => d.Nombre)
                    .ToList();

                return direcciones;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}