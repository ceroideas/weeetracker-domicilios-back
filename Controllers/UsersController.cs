using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;
using System;

namespace WeeeTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IConfiguration _config;
        private IUserService _userService;
        
        public UsersController(IConfiguration config, IUserService userService)
        {            
            _config = config;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Authenticate([FromBody]User user)
        {
            try
            {
                var token = _userService.Authenticate(_config, user.Login, user.Password);

                if (token == null)
                    return BadRequest(new { message =  Errores.UsuarioNoValido });

                return Ok(new { token = token.ToString() });
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
