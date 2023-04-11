using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using WeeeTrackerAPI.Common;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;

namespace WeeeTrackerAPI.Core.Services
{
    public class RaeeService : IRaee
    {
        private ILogger _logger;
        private IConfiguration _config;

        private GVRBD3Context _context;

        private IFirma _firmaService;
        private IFotografia _fotografiaService;
        private IResiduoEspecifico _residuoEspecificoService;
        private IEstado _estadoService;

        public RaeeService(
            ILogger<RaeeService> logger,
            IConfiguration config,
            IOptions<AppSettings> appSettings,
            GVRBD3Context context,
            IFirma firmaService,
            IFotografia fotografiaService,
            IResiduoEspecifico residuoEspecificoService,
            IEstado estadoService
            )
        {
            _logger = logger;
            _config = config;
            _context = context;

            _firmaService = firmaService;            
            _fotografiaService = fotografiaService;            
            _residuoEspecificoService = residuoEspecificoService;
            _estadoService = estadoService;
        }

        private Raees SetDatosRaee(string idRaee, Residuo residuo, ResiduosEspecificos residuoEspecifico)
        {
            Raees raee = new Raees();

            raee.PidRaee = residuo.Etiqueta;
            raee.SidResiduoEspecifico = residuo.IdResiduo;
            raee.Canibalizado = residuo.Canibalizado;
            raee.SidMarca = residuo.IdMarca;
            raee.Serie = residuo.NumSerie;
            raee.SidResiduo = residuoEspecifico.SidResiduo;
            raee.PesoEstimado = residuoEspecifico.PesoEstimado;
            raee.SidFraccion = (int)residuoEspecifico.SidFraccion;
            raee.Destino = !residuo.Funciona ? (int)Funciona.NoFunciona : (int)Funciona.Funciona;
            raee.Estado = Constantes.Estado;
            raee.SidPaisCodigoRaee = Constantes.SidPaisCodigoRaee;
            raee.SidTipoContenedor = Constantes.SidTipoContenedor;
            raee.SidTipoEtiqueta = Constantes.SidTipoEtiqueta;
            raee.SidSig = Constantes.SidSig;
            raee.SidEstadoRaee = (int)residuo.Tipo;

            return raee;
        }

        private Raees AltaRaee(Raees raee)
        {
            try
            {
                _context.Raees.Add(raee);
                _context.ChangeTracker.DetectChanges();
                _context.SaveChanges();

                return raee;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public string AltaResiduo(int idUsuario, Residuo residuo)
        {
            //*********************************************************
            //ALTA DE UNA IDENTIFICACIÓN (DOMICILIO o ESTABLECIMIENTO).
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //---------------------------------------------------------------------------------------
                    //RAEEs.

                    var raee = AltaRaee(SetDatosRaee(residuo.Etiqueta, residuo, _residuoEspecificoService.getResiduoEspecificoById(residuo.IdResiduo)));
                    if (raee == null)
                    {
                        dbContextTransaction.Rollback();
                        return null;
                    }

                    //---------------------------------------------------------------------------------------
                    //WTK_CAMBIO_ESTADO.

                    var cambioEstado = _estadoService.InsertEstado(_estadoService.SetDatosEstado(idUsuario, raee.PidRaee, residuo));
                    if (cambioEstado == null)
                    {
                        dbContextTransaction.Rollback();
                        return null;
                    }
                    
                    if (residuo.ListaArchivos.Count > 0)
                    {
                        //----------------------------------------------------------------------------------------------------------------------
                        //WTK_CAMBIO_ESTADO_FIRMA.

                        if (!_firmaService.AltaFirma(
                            residuo,
                            cambioEstado,
                            _config["Archivo:PathSigLocal"],
                            _config["Archivo:PathSigSrv"]))
                        {
                            dbContextTransaction.Rollback();
                            return null;
                        }

                        //----------------------------------------------------------------------------------------------------------------------
                        //WTK_CAMBIO_ESTADO_FOTOGRAFIA.

                        if (!_fotografiaService.AltaFotografia(
                            residuo.ListaArchivos.FindAll(a => a.Tipo == TipoArchivo.PIC).ToList(), 
                            cambioEstado.Id, 
                            _config["Archivo:PathPicLocal"],
                            _config["Archivo:PathPicSrv"]))
                        {
                            dbContextTransaction.Rollback();
                            return null;
                        }

                        
                    }
                    //--------------------------------------------------------------------------------------------------------------------------

                    dbContextTransaction.Commit();

                    return residuo.Etiqueta.ToString();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    _logger.LogError(ex.Message.ToString());
                    return null;
                }

            }
            //*********************************************************
            
        }

        public bool AltaEstado(int idUsuario, Residuo residuo)
        {
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var cambioEstado = _estadoService.InsertEstado(_estadoService.SetDatosEstado(idUsuario, residuo.Etiqueta, residuo));
                    if (cambioEstado == null)
                    {
                        dbContextTransaction.Rollback();
                        return false;
                    }

                    if (!ActualizaResiduo(residuo))
                    {
                        dbContextTransaction.Rollback();
                        return false;
                    }

                    //----------------------------------------------------------------------------------------------------------------------
                    //WTK_CAMBIO_ESTADO_FOTOGRAFIA.

                    if (!_fotografiaService.AltaFotografia(
                        residuo.ListaArchivos.FindAll(a => a.Tipo == TipoArchivo.PIC).ToList(),
                        cambioEstado.Id,
                        _config["Archivo:PathPicLocal"],
                        _config["Archivo:PathPicSrv"]))
                    {
                        dbContextTransaction.Rollback();
                        return false;
                    }

                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message.ToString());
                    return false;
                }
            }
        }

        public bool ActualizaResiduo(Residuo residuo)
        {
            try
            {
                Raees raee = SetDatosRaee(residuo.Etiqueta, residuo, _residuoEspecificoService.getResiduoEspecificoById(residuo.IdResiduo));

                _context.Raees.Attach(raee);

                _context.Entry(raee).Property(x => x.SidResiduoEspecifico).IsModified = true;
                _context.Entry(raee).Property(x => x.SidMarca).IsModified = true;
                _context.Entry(raee).Property(x => x.Serie).IsModified = true;
                _context.Entry(raee).Property(x => x.Destino).IsModified = true;
                _context.Entry(raee).Property(x => x.Canibalizado).IsModified = true;
                _context.Entry(raee).Property(x => x.SidResiduo).IsModified = true;
                _context.Entry(raee).Property(x => x.PesoEstimado).IsModified = true;
                _context.Entry(raee).Property(x => x.SidFraccion).IsModified = true;
                _context.Entry(raee).Property(x => x.Destino).IsModified = true;
                _context.Entry(raee).Property(x => x.SidEstadoRaee).IsModified = true;

                _context.ChangeTracker.DetectChanges();
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return false;
            }
        }

        public object ExisteRaee(string idRaee)
        {
            try
            {
                var raee = _context.Raees
                                .Include(r => r.SidEstadoRaeeNavigation)
                                .Where(r => r.PidRaee == idRaee && r.SidEstadoRaee == r.SidEstadoRaeeNavigation.PidEstadoRaee)
                                .Select(item => new
                                {
                                    item.PidRaee,
                                    item.SidResiduoEspecifico,
                                    item.SidMarca,
                                    item.Serie,
                                    item.Destino,
                                    item.Canibalizado,
                                    item.SidEstadoRaee,
                                    Nombre = item.SidEstadoRaeeNavigation.Nombre
                                })
                                .Join(_context.WtkCambioEstado, r=>r.PidRaee, a=>a.SidRaee, (item,a) => new{
                                    item.PidRaee,
                                    item.SidResiduoEspecifico,
                                    item.SidMarca,
                                    item.Serie,
                                    item.Destino,
                                    item.Canibalizado,
                                    item.SidEstadoRaee,
                                    item.Nombre,
                                    a.Albaran,
                                    a.Dni
                                })
                                .ToList();

                if (raee.Count == 0)
                    return null;

                return raee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public object GetRaeesResiduoEspecifico(Residuo residuo)
        {
            try
            {
                var cambioEstado = _context.Raees
                                    .Include(r => r.SidEstadoRaeeNavigation)
                                    .SelectMany(r => r.WtkCambioEstado,
                                                (parent, child) => new
                                                {
                                                    parent,
                                                    child
                                                })
                                    .Where(r=>r.parent.SidResiduoEspecifico == residuo.IdResiduo &&
                                           r.parent.SidEstadoRaee == r.parent.SidEstadoRaeeNavigation.PidEstadoRaee && 
                                           r.child.SidTercero == residuo.IdTercero && 
                                           r.child.SidDireccionTercero == residuo.IdCentro && 
                                           r.parent.SidEstadoRaee == (int)TipoEstadoIdentificacion.entrada)
                                    // .GroupBy(r=> r.parent.PidRaee)
                                    
                                    // .Select(g=>g.OrderByDescending(r=>r.child.Fecha).FirstOrDefault())
                                    
                                .Select(item => new{
                                    item.parent.PidRaee,
                                    item.parent.SidResiduoEspecifico,
                                    item.parent.SidMarca,
                                    item.parent.Serie,
                                    item.parent.Destino,
                                    item.parent.Canibalizado,
                                    item.child.Fecha,
                                    item.child.SidEstado,
                                    item.parent.SidEstadoRaeeNavigation.Nombre
                                })
                                .ToList();

                return cambioEstado;

                // if (cambioEstado.Count == 0)
                //     return null;

                // return cambioEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public object GetRaeesResiduoEspecificoUsuario(int idUsuario, int idCentro, int idResiduo)
        {
            try
            {
                var cambioEstado = _context.Raees
                                    .Include(r => r.SidEstadoRaeeNavigation)
                                    .SelectMany(r => r.WtkCambioEstado,
                                                (parent, child) => new
                                                {
                                                    parent,
                                                    child
                                                })
                                    .Where(r=>r.parent.SidResiduoEspecifico == idResiduo &&
                                        r.parent.PidRaee == r.child.SidRaee &&  
                                        r.parent.SidEstadoRaee == r.parent.SidEstadoRaeeNavigation.PidEstadoRaee && 
                                        r.child.SidUsuario == idUsuario &&
                                        r.child.SidDireccionTercero == idCentro &&
                                        (r.parent.SidEstadoRaee == (int)TipoEstadoIdentificacion.domicilio ||
                                        r.parent.SidEstadoRaee == (int)TipoEstadoIdentificacion.establecimiento))
                                    // .GroupBy(r=> r.parent.PidRaee)
                                    
                                    // .Select(g=>g.OrderByDescending(r=>r.child.Fecha).FirstOrDefault())
                                    
                                .Select(item => new{
                                    item.parent.PidRaee,
                                    item.parent.SidResiduoEspecifico,
                                    item.parent.SidMarca,
                                    item.parent.Serie,
                                    item.parent.Destino,
                                    item.parent.Canibalizado,
                                    item.child.Fecha,
                                    item.child.SidEstado,
                                    item.parent.SidEstadoRaeeNavigation.Nombre
                                })
                                .ToList();

                return cambioEstado;

                // if (cambioEstado.Count == 0)
                //     return null;

                // return cambioEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public object GetRaeesAlbaran(Residuo residuo)
        {
            try
            {
                var cambioEstado = _context.Raees
                                    .Include(r => r.SidEstadoRaeeNavigation)
                                    .SelectMany(r => r.WtkCambioEstado,
                                                (parent, child) => new
                                                {
                                                    parent,
                                                    child
                                                })
                                    .Where(r =>
                                           r.parent.SidEstadoRaee == r.parent.SidEstadoRaeeNavigation.PidEstadoRaee &&
                                           r.child.Albaran.ToUpper().Contains(residuo.Albaran.ToUpper()) &&
                                           r.child.SidTercero == residuo.IdTercero)
                                    .GroupBy(r => r.parent.PidRaee).Select(g => g.OrderByDescending(r => r.child.Fecha).FirstOrDefault());

                var listaRaee = cambioEstado
                                .Select(item => new {
                                    item.parent.PidRaee,
                                    item.parent.SidResiduoEspecifico,
                                    item.parent.SidMarca,
                                    item.parent.Serie,
                                    item.parent.Destino,
                                    item.parent.Canibalizado,
                                    item.child.Fecha,
                                    item.child.SidEstado,
                                    item.parent.SidEstadoRaeeNavigation.Nombre
                                })
                                .ToList();

                if (listaRaee.Count == 0)
                    return null;

                return listaRaee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
