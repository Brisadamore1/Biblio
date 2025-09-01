using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataContext;
using Service.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroAutoresController : ControllerBase
    {
        private readonly BiblioContext _context;

        public LibroAutoresController(BiblioContext context)
        {
            _context = context;
        }

        // GET: api/LibroAutores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibroAutor>>> GetLibroAutores([FromQuery] string filtro = "")
        {
            return await _context.LibroAutores
                .AsNoTracking()
                .Where(la => la.Libro != null && la.Libro.Titulo != null && la.Libro.Titulo.Contains(filtro))
                .ToListAsync();
        }

        [HttpGet("deleteds")]
        public async Task<ActionResult<IEnumerable<LibroAutor>>> GetDeletedsLibroAutores()
        {
            return await _context.LibroAutores
                .AsNoTracking()
                .IgnoreQueryFilters()
                .Where(a => a.IsDeleted).ToListAsync();
        }

        // GET: api/LibroAutores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LibroAutor>> GetLibroAutor(int id)
        {
            var libroAutor = await _context.LibroAutores.AsNoTracking().FirstOrDefaultAsync(la => la.Id.Equals(id));

            if (libroAutor == null)
            {
                return NotFound();
            }

            return libroAutor;
        }

        // PUT: api/LibroAutores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibroAutor(int id, LibroAutor libroAutor)
        {
            if (id != libroAutor.Id)
            {
                return BadRequest();
            }

            _context.Entry(libroAutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroAutorExists(id))
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

        // POST: api/LibroAutores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LibroAutor>> PostLibroAutor(LibroAutor libroAutor)
        {
            _context.LibroAutores.Add(libroAutor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibroAutor", new { id = libroAutor.Id }, libroAutor);
        }

        // DELETE: api/LibroAutores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibroAutor(int id)
        {
            var libroAutor = await _context.LibroAutores.FindAsync(id);
            if (libroAutor == null)
            {
                return NotFound();
            }
            libroAutor.IsDeleted=true;
            _context.LibroAutores.Update(libroAutor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreLibroAutor(int id)
        {
            var libroAutor = await _context.LibroAutores.IgnoreQueryFilters().FirstOrDefaultAsync(la => la.Id.Equals(id));
            if (libroAutor == null)
            {
                return NotFound();
            }
            libroAutor.IsDeleted = false;
            //Impacta en memoria
            _context.LibroAutores.Update(libroAutor);
            //Aca recien impacta en la base de datos
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool LibroAutorExists(int id)
        {
            return _context.LibroAutores.Any(e => e.Id == id);
        }
    }
}
