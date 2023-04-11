using System;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;

namespace WeeeTrackerAPI.Services
{
    public class FirmaService: IFirma
    {
        private ILogger _logger;
        private GVRBD3Context _context;

        public FirmaService(GVRBD3Context context, IConfiguration config)
        {
            this._context = context;
        }

        public WtkCambioEstadoFirma GuardarFirma(WtkCambioEstadoFirma firma)
        {
            try
            {
                _context.WtkCambioEstadoFirma.Add(firma);
                _context.ChangeTracker.DetectChanges();
                _context.SaveChanges();

                return firma;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public WtkCambioEstadoFirma SetDatosFirma(string nombre, string firma, int sidCambioEstado)
        {
            try
            {
                WtkCambioEstadoFirma cambioEstadoFirma = new WtkCambioEstadoFirma();

                cambioEstadoFirma.SidCambioEstado = sidCambioEstado;
                cambioEstadoFirma.Nombre = nombre;
                cambioEstadoFirma.Firma = firma;

                return cambioEstadoFirma;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public bool AltaFirma(Residuo residuo, WtkCambioEstado cambioEstado, string rutaLocal, string rutaServidor)
        {
            try
            {
                if ((cambioEstado.SidEstado == (int)TipoEstadoIdentificacion.domicilio) ||
                                (cambioEstado.SidEstado == (int)TipoEstadoIdentificacion.establecimiento))
                {
                    Archivo archivoFirma = residuo.ListaArchivos.Find(a => a.Tipo == TipoArchivo.SIG);
                    if (archivoFirma != null)
                    {
                        archivoFirma.Nombre = String.Format(Constantes.PathImageFormat, "WTK", archivoFirma.Tipo, DateTime.Now.ToFileTime(), Constantes.ImageExtension);

                        var firma = GuardarFirma(SetDatosFirma(residuo.Nombre, archivoFirma.Nombre, cambioEstado.Id));
                        if (firma != null)
                        {
                            FileHelper.SaveImage(
                                rutaLocal,
                                rutaServidor,
                                archivoFirma
                            );
                        }
                        else
                        {
                            return false;
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