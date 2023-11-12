using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Abraham_API1_P2.Server.DAL;
using Abraham_API1_P2.Shared.Models;

namespace Abraham_API1_P2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasDetallesController : ControllerBase
    {
        private readonly Context _context;

        public EntradasDetallesController(Context context)
        {
            _context = context;
        }

        // GET: api/EntradasDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntradasDetalle>>> GetEntradasDetalle()
        {
          if (_context.EntradasDetalle == null)
          {
              return NotFound();
          }
            return await _context.EntradasDetalle.ToListAsync();
        }

        // GET: api/EntradasDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntradasDetalle>> GetEntradasDetalle(int id)
        {
          if (_context.EntradasDetalle == null)
          {
              return NotFound();
          }
            var entradasDetalle = await _context.EntradasDetalle.FindAsync(id);

            if (entradasDetalle == null)
            {
                return NotFound();
            }

            return entradasDetalle;
        }

        // PUT: api/EntradasDetalles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntradasDetalle(int id, EntradasDetalle entradasDetalle)
        {
            if (id != entradasDetalle.DetalleId)
            {
                return BadRequest();
            }

            _context.Entry(entradasDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntradasDetalleExists(id))
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

        // POST: api/EntradasDetalles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EntradasDetalle>> PostEntradasDetalle(EntradasDetalle entradasDetalle)
        {
          if (_context.EntradasDetalle == null)
          {
              return Problem("Entity set 'Context.EntradasDetalle'  is null.");
          }
            _context.EntradasDetalle.Add(entradasDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntradasDetalle", new { id = entradasDetalle.DetalleId }, entradasDetalle);
        }

        // DELETE: api/EntradasDetalles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntradasDetalle(int id)
        {
            if (_context.EntradasDetalle == null)
            {
                return NotFound();
            }
            var entradasDetalle = await _context.EntradasDetalle.FindAsync(id);
            if (entradasDetalle == null)
            {
                return NotFound();
            }

            _context.EntradasDetalle.Remove(entradasDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntradasDetalleExists(int id)
        {
            return (_context.EntradasDetalle?.Any(e => e.DetalleId == id)).GetValueOrDefault();
        }
    }
}
