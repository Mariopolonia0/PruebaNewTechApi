using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.DAL;
using PruebaNewTechApi.Model;
using PruebaNewTechApi.Model.Dto;

namespace PruebaNewTechApi.Controllers
{
    [Route("api/Tareas")]
    [ApiController]
    public class TareaControllers : ControllerBase
    {
        private readonly Contexto _context;
        public TareaControllers(Contexto context)
        {
            _context = context;
        }

        private bool TareaExists(int id)
        {
            return _context.Tareas!.Any(t => t.TareaId == id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TareaDto>>> GetListTarea()
        {

            var TareasDtos = new List<TareaDto>();
            var lista = await _context.Tareas!.ToListAsync();

            lista.ForEach(tarea =>
              TareasDtos.Add(new TareaDto(_context.Usuario!.Find(tarea.UsuarioId)!, tarea))
            );

            return TareasDtos;
        }

        [HttpGet("{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetListTareaForUsuarioId(int usuarioId)
        {
            var usuarioExiste = _context.Usuario!.Any(e => e.UsuarioId == usuarioId);

            if (!usuarioExiste)
            {
                return NotFound(new Result("No existe el usuario"));
            }

            var TareasDtos = new List<TareaDto>();
            var lista = await _context.Tareas!.Where(t => t.UsuarioId == usuarioId).ToListAsync();

            lista.ForEach(tarea =>
              TareasDtos.Add(new TareaDto(_context.Usuario!.Find(tarea.UsuarioId)!, tarea))
            );

            return TareasDtos;
        }

        [HttpPost]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
            if (_context.Usuario == null)
            {
                return NotFound();
            }

            var usuarioExiste = _context.Usuario!.Any(e => e.UsuarioId == tarea.UsuarioId);

            if (!usuarioExiste)
            {
                return NotFound(new Result("No existe el usuario"));
            }

            if (TareaExists(tarea.TareaId))
            {
                _context.Tareas!.Update(tarea);
                await _context.SaveChangesAsync();
                return Ok(new Result("Actualidado"));
            }
            else
            {
                tarea.TareaId = 0;
                _context.Tareas!.Add(tarea);
                await _context.SaveChangesAsync();
                return Ok(new Result("agregado"));
            }
        }
    }
}