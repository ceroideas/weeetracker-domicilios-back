using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Logging;

using System;
using System.IO;
using System.Drawing;

using WeeeTrackerAPI.Entities;

namespace WeeeTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FileController : ControllerBase
    {
        private ILogger _logger;

        [HttpPost("upload")]
        public IActionResult GetFile([FromBody] Archivo archivo)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(archivo.ArchivoCodificado);

                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }

                image.Save(@"C:\ECOLEC\TEST\Files\PRUEBA_UPLOAD.png");

                return Ok( "OK" );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                throw new Exception(ex.Message);
            }
        }
    }
}
