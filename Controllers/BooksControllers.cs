using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.DAL;
using PruebaNewTechApi.Model;

namespace PruebaNewTechApi.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BookControllers : ControllerBase
    {
        private readonly Contexto _context;
        
        public BookControllers(Contexto context)
        {
            _context = context;
        }

        private bool BookExists(int id)
        {
            return _context.Book!.Any(e => e.BookId == id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetListBook()
        {
            return await _context.Book!.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Book!.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        } 

        [HttpPost]
        public async Task<ActionResult<Book>> PostViajes(Book book)
        {
            _context.Book!.Add(book);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.BookId }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.BookId)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Book!.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Book!.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }    
    }
}