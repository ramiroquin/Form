using Microsoft.EntityFrameworkCore;
using Portafolio.Models;
using Portafolio.Servicios.Contrato;

namespace Portafolio.Servicios.Implentacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly PortafolioContext _context;

        public UsuarioService(PortafolioContext context)
        {
            _context = context;   
        }
        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _context.Usuarios.Where(u => u.Correo == correo && u.Clave == clave)
                .FirstOrDefaultAsync();
            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _context.Usuarios.Add(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }
    }
}
