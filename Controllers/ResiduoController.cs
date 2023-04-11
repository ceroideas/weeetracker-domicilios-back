using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Security.Claims;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;

namespace WeeeTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ResiduoController : ControllerBase
    {
        private IRaee _raeeService;
        
        public ResiduoController(IRaee residuoService)
        {
            _raeeService = residuoService;   
        }

        [HttpPost]
        public IActionResult GetResiduo([FromBody]Residuo residuo)
        {
            try
            {
                object raees = _raeeService.ExisteRaee(residuo.Etiqueta);
                if (raees != null)
                    return Ok(raees);
                
                return NotFound(new { residuo = Errores.EtiquetaNoExiste });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("alta")]
        public IActionResult AltaResiduo([FromBody]Residuo residuo)
        {
            try
            {                
                //--------------------------------------------------------------------------------------
                //Obtener el Id de Usuario del Token, para ello tiene que estar autenticado.
                Claim claimIdUsuario = JWTHelper.GetClaim(User.Claims, Claims.Id.ToString());
                if (claimIdUsuario == null || claimIdUsuario.Value == string.Empty)
                    return BadRequest(new { message = Errores.UsuarioNoValido });

                //--------------------------------------------------------------------------------------
                //Alta del Residuo.
                var idResiduo = _raeeService.AltaResiduo(short.Parse(claimIdUsuario.Value),residuo);
                if (idResiduo == null) 
                    return BadRequest(new { error = Errores.EtiquetaAlta });

                //--------------------------------------------------------------------------------------
                //Si el alta ha sido correcta, devolvemos el Identificador del Residuo.
                return Ok(new { residuo = idResiduo.ToString() });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("especifico")]
        public IActionResult GetEtiquetasResiduoEspecifico([FromBody]Residuo residuo)
        {
            try
            {
                object listaResiduos = _raeeService.GetRaeesResiduoEspecifico(residuo);
                if (listaResiduos == null)
                    return NotFound(new { stock = Errores.ResiduoNoExiste });

                return Ok(new { residuo = listaResiduos });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("especifico-usuario/{idUsuario}/{idCentro}/{idResiduo}")]
        public IActionResult GetEtiquetasResiduoEspecificoUsuario(int idUsuario, int idCentro, int idResiduo)
        {
            try
            {
                object listaResiduos = _raeeService.GetRaeesResiduoEspecificoUsuario(idUsuario, idCentro, idResiduo);
                if (listaResiduos == null)
                    return NotFound(new { stock = Errores.ResiduoNoExiste });

                return Ok(new { residuo = listaResiduos });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("albaran")]
        public IActionResult GetEtiquetasAlbaran([FromBody]Residuo residuo)
        {
            try
            {
                object listaResiduos = _raeeService.GetRaeesAlbaran(residuo);
                if (listaResiduos == null)
                    return NotFound(new { stock = Errores.ResiduoNoExiste });

                return Ok(new { residuo = listaResiduos });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
