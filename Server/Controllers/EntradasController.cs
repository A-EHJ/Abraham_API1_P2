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
    public class EntradasController : ControllerBase
    {
        private readonly Context _context;

        public EntradasController(Context context)
        {
            _context = context;
        }

        // GET: api/Entradas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entradas>>> GetEntrada()
        {
          if (_context.Entrada == null)
          {
              return NotFound();
          }
            return await _context.Entrada.ToListAsync();
        }

        // GET: api/Entradas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entradas>> GetEntradas(int id)
        {
          if (_context.Entrada == null)
          {
              return NotFound();
          }

            var entradas = await _context.Entrada
            .Where(e => e.EntradaId == id).Include(e => e.EntradasDetalle)
            .AsNoTracking()
            .FirstOrDefaultAsync();

            if (entradas == null)
            {
                return NotFound();
            }

            return entradas;
        }

        // PUT: api/Entradas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntradas(int id, Entradas entradas)
        {
            if (id != entradas.EntradaId)
            {
                return BadRequest();
            }

            _context.Entry(entradas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntradasExists(id))
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

        // POST: api/Entradas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entradas>> PostEntradas(Entradas entradas)
        {
          if (!EntradasExists(entradas.EntradaId))
                _context.Entrada.Add(entradas);
          else
                _context.Entrada.Update(entradas);

            await _context.SaveChangesAsync();

            return Ok(entradas);
        }

        // DELETE: api/Entradas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntradas(int id)
        {
            if (_context.Entrada == null)
            {
                return NotFound();
            }
            var entradas = await _context.Entrada.FindAsync(id);
            if (entradas == null)
            {
                return NotFound();
            }

            _context.Entrada.Remove(entradas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntradasExists(int id)
        {
            return (_context.Entrada?.Any(e => e.EntradaId == id)).GetValueOrDefault();
        }
    }
}
