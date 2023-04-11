using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using WeeeTrackerAPI.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Common
{
    public class JWTHelper
    {
        public static string GetToken(
            IConfiguration config,
            WtkUsuario usuario,
            object tercero,
            object centros,
            object perfiles,
            object residuosEspecificos,
            object marcas
            )
        {
            //----------------------------------------------------------------------------------------------------------------------------
            // Generación del Token JWT.

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(config["Jwt:Key"].PadRight(16, '0'));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(Claims.Id.ToString(), ((long)usuario.Id).ToString()),
                        new Claim(Claims.Login.ToString(), usuario.Usuario),
                        new Claim(Claims.Tercero.ToString(), JsonConvert.SerializeObject(tercero)),
                        new Claim(Claims.TipoTercero.ToString(), ((long)usuario.SidTipoTercero).ToString()),
                        new Claim(Claims.Estado.ToString(), ((long)usuario.Estado).ToString()),
                        new Claim(Claims.Centros.ToString(), JsonConvert.SerializeObject(centros)),
                        new Claim(Claims.Perfiles.ToString(), JsonConvert.SerializeObject(perfiles)),
                        new Claim(Claims.Residuos.ToString(), JsonConvert.SerializeObject(residuosEspecificos)),
                        new Claim(Claims.Marcas.ToString(), JsonConvert.SerializeObject(marcas))
                }),
                Issuer = config["Jwt:Issuer"],
                Audience = config["Jwt:Audience"],
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(config["Jwt:ExpireMin"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

            //----------------------------------------------------------------------------------------------------------------------------
        }

        public static Claim GetClaim(IEnumerable<Claim> claims, string nombre)
        {
            Claim claim = claims.FirstOrDefault(c => c.Type == nombre);
            return claim;
        }
    }
}
