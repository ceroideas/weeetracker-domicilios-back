using System;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;

namespace WeeeTrackerAPI.Services
{
    public class FotografiaService : IFotografia
    {
        private ILogger _logger;

        private GVRBD3Context _context;

        public FotografiaService(GVRBD3Context context)
        {
            this._context = context;
        }

        public WtkCambioEstadoFotografia GuardarFotografia(WtkCambioEstadoFotografia fotografia)
        {
            try
            {
                _context.WtkCambioEstadoFotografia.Add(fotografia);
                _context.ChangeTracker.DetectChanges();
                _context.SaveChanges();

                return fotografia;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public WtkCambioEstadoFotografia SetDatosFotografia(string fichero, int sidCambioEstado)
        {
            try
            {
                WtkCambioEstadoFotografia cambioEstadoFotografia = new WtkCambioEstadoFotografia();

                cambioEstadoFotografia.SidCambioEstado = sidCambioEstado;
                cambioEstadoFotografia.Fichero = fichero;

                return cambioEstadoFotografia;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public bool AltaFotografia(List<Archivo> listaImagenes, int idCambioEstado, string rutaLocal, string rutaServidor)
        {
            try
            {
                if (listaImagenes != null)
                {
                    if (listaImagenes.Count > 0)
                    {
                        int cont = 0;

                        foreach (Archivo archivo in listaImagenes)
                        {
                            cont++;

                            archivo.Nombre = String.Format(Constantes.PathImageFormat, "WTK", archivo.Tipo, DateTime.Now.ToFileTime(), Constantes.ImageExtension);

                            var firma = GuardarFotografia(SetDatosFotografia(archivo.Nombre, idCambioEstado));
                            if (firma != null)
                            {
                                FileHelper.SaveImage(
                                    rutaLocal,
                                    rutaServidor,
                                    archivo
                                );
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return false;
            }
        }
    }
}