namespace E_learning_API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using E_learning_API.Data;
    using E_learning_API.Model;

    
    [ApiController]
    [Route("api/[controller]")]
    public class LeccionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeccionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Leccion>>> GetLecciones()
        {
            return await _context.Lecciones.Include(l => l.Preguntas).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Leccion>> GetLeccion(int id)
        {
            var leccion = await _context.Lecciones.Include(l => l.Preguntas)
                                                  .FirstOrDefaultAsync(l => l.Id == id);

            if (leccion == null)
            {
                return NotFound();
            }

            return leccion;
        }

        [HttpPost]
        public async Task<ActionResult<Leccion>> PostLeccion(Leccion leccion)
        {
            _context.Lecciones.Add(leccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLeccion", new { id = leccion.Id }, leccion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeccion(int id, Leccion leccion)
        {
            if (id != leccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(leccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeccionExists(id))
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
        public async Task<IActionResult> DeleteLeccion(int id)
        {
            var leccion = await _context.Lecciones.FindAsync(id);
            if (leccion == null)
            {
                return NotFound();
            }

            _context.Lecciones.Remove(leccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LeccionExists(int id)
        {
            return _context.Lecciones.Any(e => e.Id == id);
        }
    }

}
