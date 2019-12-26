using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaHeinson.Data;
using PruebaHeinson.Models;

namespace PruebaHeinson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoysController : ControllerBase
    {
        private readonly PruebaHeinsonContext _context;

        public CategoysController(PruebaHeinsonContext context)
        {
            _context = context;
        }

        // GET: api/Categoys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoy>>> GetCategoy()
        {
            return await _context.Categoy.ToListAsync();
        }

        // GET: api/Categoys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoy>> GetCategoy(int id)
        {
            var categoy = await _context.Categoy.FindAsync(id);

            if (categoy == null)
            {
                return NotFound();
            }

            return categoy;
        }

        // PUT: api/Categoys/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoy(int id, Categoy categoy)
        {
            if (id != categoy.idCategoiry)
            {
                return BadRequest();
            }

            _context.Entry(categoy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoyExists(id))
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

        // POST: api/Categoys
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Categoy>> PostCategoy(Categoy categoy)
        {
            _context.Categoy.Add(categoy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoy", new { id = categoy.idCategoiry }, categoy);
        }

        // DELETE: api/Categoys/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoy>> DeleteCategoy(int id)
        {
            var categoy = await _context.Categoy.FindAsync(id);
            if (categoy == null)
            {
                return NotFound();
            }

            _context.Categoy.Remove(categoy);
            await _context.SaveChangesAsync();

            return categoy;
        }

        private bool CategoyExists(int id)
        {
            return _context.Categoy.Any(e => e.idCategoiry == id);
        }
    }
}
