using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JsaApi.Models;

namespace JsaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsaSourceController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaSourceController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaSources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaSource>>> GetJsaSources()
        {
            return await _context.JsaSources.ToListAsync();
        }

        // GET: api/JsaSources/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaSource>> GetJsaSource(int id)
        {
            var jsaSource = await _context.JsaSources.FindAsync(id);

            if (jsaSource == null)
            {
                return NotFound();
            }

            return jsaSource;
        }

        // PUT: api/JsaSources/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaSource(int id, JsaSource jsaSource)
        {
            if (id != jsaSource.SId)
            {
                return BadRequest();
            }

            _context.Entry(jsaSource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaSourceExists(id))
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

        // POST: api/JsaSources
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaSource>> PostJsaSource(JsaSource jsaSource)
        {
            _context.JsaSources.Add(jsaSource);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaSourceExists(jsaSource.SId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaSource", new { id = jsaSource.SId }, jsaSource);
        }

        // DELETE: api/JsaSources/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaSource(int id)
        {
            var jsaSource = await _context.JsaSources.FindAsync(id);
            if (jsaSource == null)
            {
                return NotFound();
            }

            _context.JsaSources.Remove(jsaSource);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaSourceExists(int id)
        {
            return _context.JsaSources.Any(e => e.SId == id);
        }
    }
}
