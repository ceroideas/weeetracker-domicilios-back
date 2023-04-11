using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Options;
using WeeeTrackerAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Common;
using Microsoft.AspNetCore.Identity;
using WeeeTrackerAPI.Entities;

namespace WeeeTrackerAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private ILogger _logger;

        private TerceroService _terceroService;
        private CentroService _centroService;
        private ResiduoEspecificoService _residuoEspecificoService;
        private MarcaService _marcaService;
        private WtkUsuario _usuario;
        private GVRBD3Context _context;

        public UserService(ILogger<UserService> logger, IOptions<AppSettings> appSettings, GVRBD3Context context)
        {
            _appSettings = appSettings.Value;
            _logger = logger;
            _context = context;

            _terceroService = new TerceroService(_context);
            _centroService = new CentroService(_context);
            _residuoEspecificoService = new ResiduoEspecificoService(_context);
            _marcaService = new MarcaService(_context);
        }

        public WtkUsuario getUsuario(string username, string password)
        {
            try
            {
                WtkUsuario usuario = _context.WtkUsuario
                    .Where(u => u.Usuario == username && u.Password == password)
                    .Include(u => u.WtkUsuarioPerfiles)
                    .Select(item => new WtkUsuario
                    {
                        Id = item.Id,
                        Usuario = item.Usuario,
                        Password = item.Password,
                        SidTercero = item.SidTercero,
                        SidTipoTercero = item.SidTipoTercero,
                        Estado = item.Estado,
                        WtkUsuarioPerfiles = item.WtkUsuarioPerfiles
                    })
                    .FirstOrDefault();

                return usuario;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public WtkUsuario getUsuarioById(int idUsuario)
        {
            try
            {
                WtkUsuario usuario = _context.WtkUsuario
                                            .Where(u =>
                                                u.Id == idUsuario
                                            )
                                            .FirstOrDefault();

                return usuario;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public object getPerfiles(WtkUsuario usuario)
        {
            try
            {
                var perfiles = usuario.WtkUsuarioPerfiles
                    .Select(item => new
                    {
                        item.SidPerfil
                    })
                    .ToList();

                return perfiles;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public string Authenticate(IConfiguration config, string username, string password)
        {
            try
            {
                //----------------------------------------------------------------------------------------------------------------------------
                //Usuario autenticado y sus perfiles asociados.

                this._usuario = getUsuario(username, password);
                if (this._usuario == null)
                    return null;

                //----------------------------------------------------------------------------------------------------------------------------
                //Verificamos la password hasheada en la Base de Datos.

                //genera la password hasheada.
                //var hasher = new PasswordHasher<WtkUsuario>().HashPassword(_usuario, _usuario.Password);

                //se la asigno a la password hardcode para simular la verificaci�n de la misma.
                //_usuario.Password = "AQAAAAEAACcQAAAAEO+TBI8TRfmXp3HuIj9QOScByhl6O0ctDihEkV9ecvrOUZPMSfbIhEJQ5iaHHet73A==";

                //Verificamos la password mediante el  hash.
                //PasswordVerificationResult pvr = new PasswordHasher<WtkUsuario>().VerifyHashedPassword(_usuario, _usuario.Password, password);
                //if (pvr == PasswordVerificationResult.Failed)
                //    return null;

                //----------------------------------------------------------------------------------------------------------------------------
                // Generaci�n del Token.

                return JWTHelper.GetToken(
                    config,
                    this._usuario,
                    _terceroService.getTercero(this._usuario),
                    _centroService.getCentros(this._usuario),
                    getPerfiles(this._usuario),
                    _residuoEspecificoService.getResiduos(),
                    _marcaService.getMarcas()
                );
                
                //----------------------------------------------------------------------------------------------------------------------------

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}