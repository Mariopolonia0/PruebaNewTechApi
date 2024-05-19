using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.DAL;
using PruebaNewTechApi.Model.ControlTarea;

namespace PruebaNewTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly Contexto _context;

        public TareaController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Tarea
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetTarea()
        {
          if (_context.Tarea == null)
          {
              return NotFound();
          }
            return await _context.Tarea.ToListAsync();
        }

        // GET: api/Tarea/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTarea(int id)
        {
          if (_context.Tarea == null)
          {
              return NotFound();
          }
            var tarea = await _context.Tarea.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return tarea;
        }

        // PUT: api/Tarea/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarea(int id, Tarea tarea)
        {
            if (id != tarea.tareaId)
            {
                return BadRequest();
            }

            _context.Entry(tarea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tarea
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
          if (_context.Tarea == null)
          {
              return Problem("Entity set 'Contexto.Tarea'  is null.");
          }
            _context.Tarea.Add(tarea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarea", new { id = tarea.tareaId }, tarea);
        }

        // DELETE: api/Tarea/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarea(int id)
        {
            if (_context.Tarea == null)
            {
                return NotFound();
            }
            var tarea = await _context.Tarea.FindAsync(id);
            if (tarea == null)
            {
                return NotFound();
            }

            _context.Tarea.Remove(tarea);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TareaExists(int id)
        {
            return (_context.Tarea?.Any(e => e.tareaId == id)).GetValueOrDefault();
        }
    }
}
