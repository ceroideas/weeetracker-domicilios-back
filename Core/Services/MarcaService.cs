using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;

namespace WeeeTrackerAPI.Services
{

    public class MarcaService : IMarca
    {
        private GVRBD3Context _context;

        public MarcaService(GVRBD3Context context)
        {
            this._context = context;
        }

        public object getMarcas()
        {
            try
            {
                var marcas = _context.Marcas
                     .Select(item => new
                     {
                         item.PidMarca,
                         item.Nombre
                     })
                     .OrderBy(m => m.Nombre)
                     .ToList();

                return marcas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}