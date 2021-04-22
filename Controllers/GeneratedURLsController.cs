using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShortlyBE.Models;

namespace ShortlyBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneratedURLsController : ControllerBase
    {
        private readonly URLContext _context;

        public GeneratedURLsController(URLContext context)
        {
            _context = context;
        }

        // GET: api/GeneratedURLs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneratedURLs>>> GetGeneratedURL()
        {
            return await _context.GeneratedURL.ToListAsync();
        }

        // GET: api/GeneratedURLs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneratedURLs>> GetGeneratedURLs(long id)
        {
            var generatedURLs = await _context.GeneratedURL.FindAsync(id);

            if (generatedURLs == null)
            {
                return NotFound();
            }

            return generatedURLs;
        }

        // PUT: api/GeneratedURLs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutGeneratedURLs(long id, GeneratedURLs generatedURLs)
        // {
        //     if (id != generatedURLs.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(generatedURLs).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!GeneratedURLsExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // POST: api/GeneratedURLs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GeneratedURLs>> PostGeneratedURLs(GeneratedURLs generatedURLs)
        {
            _context.GeneratedURL.Add(generatedURLs);
            await _context.SaveChangesAsync();

                
            // return CreatedAtAction("GetGeneratedURLs", new { id = generatedURLs.Id }, generatedURLs);
             return CreatedAtAction(nameof(GetGeneratedURLs), new { id = generatedURLs.Id }, generatedURLs);
            
        }

        // DELETE: api/GeneratedURLs/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteGeneratedURLs(long id)
        // {
        //     var generatedURLs = await _context.GeneratedURL.FindAsync(id);
        //     if (generatedURLs == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.GeneratedURL.Remove(generatedURLs);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        // private bool GeneratedURLsExists(long id)
        // {
        //     return _context.GeneratedURL.Any(e => e.Id == id);
        // }
    }
}
