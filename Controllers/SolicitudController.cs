using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

using System.Threading.Tasks;

using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Security.Claims;
using System.Xml.Linq;
using System.Text;
using System.Linq;

namespace WeeeTrackerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SolicitudController : ControllerBase
    {
        ISolicitud _solicitudService;

        public SolicitudController(ISolicitud solicitudService)
        {
            _solicitudService = solicitudService;
        }

        [HttpPost("consulta")]
        public async Task<IActionResult> GetSolicitudes([FromBody]SolicitudFiltros solicitud)
        {
            try
            {
                XElement xml = await _solicitudService.GetSolicitudes(solicitud);
                if (xml == null)
                    return BadRequest(new { message = Errores.SolicitudConsultaNoValido });

                List<SolicitudConsulta> lista = _solicitudService.SetDatosSolicitudConsulta(xml.ToString());

                if (lista == null)
                    return BadRequest(new { message = Errores.SolicitudConsultaXML });

                // return Ok(new { solicitud = lista });

                if (solicitud.Estado != "")
                    lista = lista.FindAll(s => s.est == solicitud.Estado.ToString()).ToList();

                return Ok(new { solicitud = lista });
            }
            catch(Exception ex)
            {
                return NotFound(new { message = Errores.SolicitudConsultaNoValido });
            }
        }

        [HttpPost("alta")]
        public async Task<IActionResult> AltaSolicitud([FromBody]SolicitudFiltros solicitud)
        {
            try
            {
                if(solicitud == null)
                    return BadRequest(new { message = Errores.SolicitudAlta });

                Claim claimIdUsuario = JWTHelper.GetClaim(User.Claims, Claims.Id.ToString());
                if (claimIdUsuario == null || claimIdUsuario.Value == string.Empty)
                    return BadRequest(new { message = Errores.UsuarioNoValido });

                var response = await _solicitudService.AltaSolicitudAsync(
                                            _solicitudService.SetDatosSolicitudesAlta(
                                                short.Parse(claimIdUsuario.Value),
                                                solicitud)
                                        );
                if(response != null)
                    return Ok(new { solicitud = response });

                return BadRequest(new { message = Errores.SolicitudAlta });
            }
            catch
            {
                return NotFound(new { message = Errores.SolicitudAlta });
            }
        }

        [HttpPost("validacion")]
        public async Task<IActionResult> ValidacionSolicitud([FromBody]SolicitudValidacion solicitud)
        {
            try
            {
                return Ok(new { solicitud = await _solicitudService.ValidacionSolicitud(solicitud) });
            }
            catch
            {
                return NotFound(new { message = Errores.SolicitudValidacion });
            }
        }

    }
}