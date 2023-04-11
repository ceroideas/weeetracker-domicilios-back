using Microsoft.Extensions.Configuration;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IUserService
    {
        WtkUsuario getUsuario(string username, string password);
        WtkUsuario getUsuarioById(int idUsuario);
        object getPerfiles(WtkUsuario usuario);
        string Authenticate(IConfiguration config, string username, string password);
    }
}
