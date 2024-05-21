using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.DAL;
using PruebaNewTechApi.Model;

namespace PruebaNewTechApi.Controllers
{
    [Route("Usuario")]
    [ApiController]
    public class UsuarioControllers : ControllerBase
    {
        private readonly Contexto _context;
        public UsuarioControllers(Contexto context)
        {
            _context = context;
        }
        private bool UsuarioExists(int id)
        {
            return _context.Usuario!.Any(e => e.UsuarioId == id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetListUsuario()
        {
            return await _context.Usuario!.ToListAsync();
        }
    }
}
