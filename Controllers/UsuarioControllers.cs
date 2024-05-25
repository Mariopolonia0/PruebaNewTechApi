using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.DAL;
using PruebaNewTechApi.Model;
using PruebaNewTechApi.Model.Dto;

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

        [HttpGet("{Empresa}")]
        public async Task<ActionResult<IEnumerable<UsuarioForTareas>>> GetUsuarioForTareas(String Empresa)
        {
            var usuarios = new List<UsuarioForTareas>();

            await _context.Usuario!.Where(u => u.NombreEmpresa == Empresa).
                ForEachAsync(usuario => usuarios.Add(
                    new UsuarioForTareas(usuario.UsuarioId, usuario.Nombre + " " + usuario.Apellido))
                );

            return usuarios;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<Usuario>> GetLogin(LoginIn loginIn)
        {
            if (_context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario!.FirstOrDefaultAsync(
                    Login => Login.NombreUsuario == loginIn.nombreUsuario
                );

            if (usuario != null)
                if (usuario.Password == loginIn.password)
                    return Ok(usuario);

            return BadRequest("no esta registrado");
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            if (_context.Usuario == null)
            {
                return NotFound();
            }

            if (UsuarioExists(usuario.UsuarioId))
            {
                _context.Entry(usuario).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok("actulizado");
            }
            else
            {
                usuario.UsuarioId = 0;
                var result = Verificar(usuario);

                if (result == string.Empty)
                {
                    _context.Usuario.Add(usuario);
                    await _context.SaveChangesAsync();
                    return Ok("agregado");
                }
                else
                    return BadRequest(result);
            }
        }

        private string Verificar(Usuario usuario)
        {
            var result = string.Empty;

            if (_context.Usuario!.Any(e => e.Apellido == usuario.Apellido))
                result = "El apellido ya existe";

            else if (_context.Usuario!.Any(e => e.NombreUsuario == usuario.NombreUsuario))
                result = "El nombre usuario ya existe";

            return result;
        }
    }
}
