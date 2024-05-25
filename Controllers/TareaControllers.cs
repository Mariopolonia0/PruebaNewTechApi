using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.DAL;
using PruebaNewTechApi.Model;

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
        public async Task<ActionResult<IEnumerable<Tarea>>> GetListBook()
        {
            return await _context.Tareas!.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
            if (_context.Usuario == null)
            {
                return NotFound();
            }

            if (TareaExists(tarea.TareaId))
            {
                _context.Tareas!.Update(tarea);
                await _context.SaveChangesAsync();
                return Ok("actulizado");
            }
            else
            {
                tarea.TareaId = 0;
                _context.Tareas!.Add(tarea);
                await _context.SaveChangesAsync();
                return Ok("agregado");
            }
        }
    }
}
