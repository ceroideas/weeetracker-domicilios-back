using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;

namespace WeeeTrackerAPI.Services
{
    public class EstadoService : IEstado
    {
        private ILogger _logger;
        private IConfiguration _config;
        private GVRBD3Context _context;
        private IFotografia _fotografiaService;

        public EstadoService(GVRBD3Context context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public WtkCambioEstado InsertEstado(WtkCambioEstado cambioEstado)
        {
            try
            {                
                _context.WtkCambioEstado.Add(cambioEstado);
                _context.ChangeTracker.DetectChanges();
                _context.SaveChanges();

                return cambioEstado;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public int UpdateEstado(WtkCambioEstado cambioEstado)
        {
            try
            {
                WtkCambioEstado cambioEstadoUpdate =
                    _context.WtkCambioEstado
                        .Select(item => new WtkCambioEstado
                        {
                            Id = item.Id,
                            SidRaee = item.SidRaee
                        })
                        .LastOrDefault(p => p.SidRaee == cambioEstado.SidRaee);

                cambioEstado.Id = cambioEstadoUpdate.Id;

                _context.WtkCambioEstado.Update(cambioEstado);
                _context.ChangeTracker.DetectChanges();
                _context.SaveChanges();

                return cambioEstado.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return 0;
            }
        }

        public WtkCambioEstado SetDatosEstado(int idUsuario, string idRaee, Residuo residuo)
        {
            try
            {
                WtkCambioEstado cambioEstado = new WtkCambioEstado();
                
                cambioEstado.Albaran = residuo.Albaran;
                cambioEstado.Dni = residuo.DNI;
                cambioEstado.Fecha = Convert.ToDateTime(residuo.Fecha);
                cambioEstado.SidRaee = idRaee;
                cambioEstado.SidTercero = residuo.IdTercero;
                cambioEstado.SidDireccionTercero = residuo.IdCentro;
                cambioEstado.SidUsuario = idUsuario;
                cambioEstado.SidEstado = (int)residuo.Tipo;
                cambioEstado.GpsX = residuo.Coordenadas.Longitud;
                cambioEstado.GpsY = residuo.Coordenadas.Latitud;
                cambioEstado.SidEstado = (int)residuo.Tipo;

                return cambioEstado;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public WtkCambioEstado ExisteEntrada(string idRaee)
        {
            try
            {
                WtkCambioEstado cambioEstado = _context.WtkCambioEstado
                    .Where(
                        c => c.SidRaee == idRaee 
                        && c.SidEstado == (int)TipoEstadoIdentificacion.entrada)
                    .FirstOrDefault();

                return cambioEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public WtkCambioEstado ExisteEntrada(string idRaee, int idCentro)
        {
            try
            {
                WtkCambioEstado cambioEstado = _context.WtkCambioEstado
                    .Where(
                        c => c.SidRaee == idRaee
                        && c.SidEstado == (int)TipoEstadoIdentificacion.entrada
                        && c.SidDireccionTercero == idCentro)
                    .FirstOrDefault();

                return cambioEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public WtkCambioEstado ExisteSalida(string idRaee)
        {
            try
            {
                WtkCambioEstado cambioEstado = _context.WtkCambioEstado
                    .Where(
                        c => c.SidRaee == idRaee
                        && c.SidEstado == (int)TipoEstadoIdentificacion.salida)
                    .FirstOrDefault();

                return cambioEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}