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
    public class SourceTypeController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public SourceTypeController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaSourceTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaSourceType>>> GetJsaSourceTypes()
        {
            return await _context.JsaSourceTypes.ToListAsync();
        }

        // GET: api/JsaSourceTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaSourceType>> GetJsaSourceType(int id)
        {
            var jsaSourceType = await _context.JsaSourceTypes.FindAsync(id);

            if (jsaSourceType == null)
            {
                return NotFound();
            }

            return jsaSourceType;
        }

        // PUT: api/JsaSourceTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaSourceType(int id, JsaSourceType jsaSourceType)
        {
            if (id != jsaSourceType.StId)
            {
                return BadRequest();
            }

            _context.Entry(jsaSourceType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaSourceTypeExists(id))
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

        // POST: api/JsaSourceTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaSourceType>> PostJsaSourceType(JsaSourceType jsaSourceType)
        {
            _context.JsaSourceTypes.Add(jsaSourceType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaSourceTypeExists(jsaSourceType.StId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaSourceType", new { id = jsaSourceType.StId }, jsaSourceType);
        }

        // DELETE: api/JsaSourceTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaSourceType(int id)
        {
            var jsaSourceType = await _context.JsaSourceTypes.FindAsync(id);
            if (jsaSourceType == null)
            {
                return NotFound();
            }

            _context.JsaSourceTypes.Remove(jsaSourceType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaSourceTypeExists(int id)
        {
            return _context.JsaSourceTypes.Any(e => e.StId == id);
        }
    }
}
