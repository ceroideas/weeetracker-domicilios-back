using Microsoft.Extensions.Configuration;
using ServiceEcoapp;

namespace WeeeTrackerAPI.Common
{
    public static class ServiceEcoAppConfig
    {
        public static CabeceraSoap GetCabeceraEcoApp(IConfiguration _config)
        {
            CabeceraSoap cabecera = new CabeceraSoap();
            cabecera.UserName = _config["Ecopp:ecoapp_usuario"];
            cabecera.PassWord = _config["Ecopp:ecoapp_password"];
            cabecera.CiaPrincipal = _config["Ecopp:ecoapp_ciaPrincipal"];
            cabecera.CiaUsuario = _config["Ecopp:ecoapp_ciaUsuario"];

            return cabecera;
        }

        public static ServiciosSoapClient GetClientEcoApp()
        {
            return new ServiciosSoapClient(ServiciosSoapClient.EndpointConfiguration.ServiciosSoap12);
        }

    }
}
