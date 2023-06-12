using Portafolio.Models;

namespace Portafolio.Servicios.Contrato
{
    public interface IUsuarioService
    {
        // Devuelve un usuario
        Task<Usuario> GetUsuario(string correo, string clave);

        // Guarda el usuario
        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
