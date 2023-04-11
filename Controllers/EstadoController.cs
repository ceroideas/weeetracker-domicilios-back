using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

using System;
using System.Security.Claims;

using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Common;
using WeeeTrackerAPI.Services;

namespace WeeeTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EstadoController : ControllerBase
    {

        private IEstado _estadoService;
        private IRaee _raeeService;
        
        public EstadoController(
            IRaee raeeService,
            IEstado estadoService
        )
        {
            _estadoService = estadoService;
            _raeeService = raeeService;
        }

        
        [HttpPost("entrada")]
        public IActionResult GetEntrada([FromBody]Residuo residuo)
        {
            try
            {
                WtkCambioEstado cambioEstado = _estadoService.ExisteEntrada(residuo.Etiqueta);
                if (cambioEstado == null)
                    return NotFound(new { residuo = Errores.EntradaNoExiste });
                
                return Ok(cambioEstado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("entrada/centro")]
        public IActionResult GetEntradaCentro([FromBody]Residuo residuo)
        {
            try
            {
                WtkCambioEstado cambioEstado = _estadoService.ExisteEntrada(residuo.Etiqueta, residuo.IdCentro);
                if (cambioEstado == null)
                    return NotFound(new { residuo = Errores.EntradaNoExiste });

                return Ok(cambioEstado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("salida")]
        public IActionResult GetSalida([FromBody]Residuo residuo)
        {
            try
            {
                WtkCambioEstado cambioEstado = _estadoService.ExisteSalida(residuo.Etiqueta);
                if (cambioEstado == null)
                    return NotFound(new { residuo = Errores.SalidaNoExiste });

                return Ok(cambioEstado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        [HttpPut("entrada")]
        public IActionResult AltaEntrada([FromBody]Residuo residuo)
        {
            try
            {
                Claim claimIdUsuario = JWTHelper.GetClaim(User.Claims, Claims.Id.ToString());
                if (claimIdUsuario == null || claimIdUsuario.Value == string.Empty)
                    return BadRequest(new { message = Errores.UsuarioNoValido });
                
                if (!_raeeService.AltaEstado(short.Parse(claimIdUsuario.Value),residuo))
                    return NotFound(new { etiqueta = Errores.EntradaAlta });
                
                return Ok(new { residuo = Errores.EntradaOk });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("salida")]
        public IActionResult AltaSalida([FromBody]Residuo residuo)
        {
            try
            {
                Claim claimIdUsuario = JWTHelper.GetClaim(User.Claims, Claims.Id.ToString());
                if (claimIdUsuario == null || claimIdUsuario.Value == string.Empty)
                    return BadRequest(new { message = Errores.UsuarioNoValido });

                if (!_raeeService.AltaEstado(short.Parse(claimIdUsuario.Value), residuo))
                    return NotFound(new { etiqueta = Errores.SalidaAlta });

                return Ok(new { residuo = Errores.SalidaOk });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
