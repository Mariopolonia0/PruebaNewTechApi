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

            await _context.Usuario!.Where(u => u.NumeroLicencia == Empresa).
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
                    Login => Login.NombreUsuario == loginIn.NombreUsuario
                );

            if (usuario != null)
                if (usuario.Password == loginIn.Password)
                    return Ok(usuario);

            return Ok(new Usuario());
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            Result resultMensseger = new ();

            if (_context.Usuario == null)
            {
                return NotFound();
            }

            if (UsuarioExists(usuario.UsuarioId))
            {
                _context.Entry(usuario).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                resultMensseger.DataResult = "Actualizado";
                return Ok(resultMensseger);
            }
            else
            {
                usuario.UsuarioId = 0;
                var result = Verificar(usuario);

                if (result == string.Empty)
                {
                    _context.Usuario.Add(usuario);
                    await _context.SaveChangesAsync();
                    resultMensseger.DataResult = "Se agregó el usuario";
                    return Ok(resultMensseger);
                }
                else
                {
                    resultMensseger.DataResult = result;
                    return BadRequest(resultMensseger);
                }
            }
        }

        private string Verificar(Usuario usuario)
        {
            var result = string.Empty;

            var nombreExiste = _context.Usuario!.Any(e => e.Nombre == usuario.Nombre);
            var apellidoExiste = _context.Usuario!.Any(e => e.Apellido == usuario.Apellido);

            if (nombreExiste && apellidoExiste)
                result = "Usted esta registrado";

            else if (_context.Usuario!.Any(e => e.NombreUsuario == usuario.NombreUsuario))
                result = "El nombre usuario ya existe";

            else if (!_context.Licencias!.Any(e => e.NumeroLicencia == usuario.NumeroLicencia))
                result = "La licencia no existe";

            return result;
        }
    }
}
