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
    public class JsaLocation2BusinessController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaLocation2BusinessController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaLocation2Business
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaLocation2Business>>> GetJsaLocation2Businesses()
        {
            return await _context.JsaLocation2Businesses.ToListAsync();
        }

        // GET: api/JsaLocation2Business/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaLocation2Business>> GetJsaLocation2Business(int id)
        {
            var jsaLocation2Business = await _context.JsaLocation2Businesses.FindAsync(id);

            if (jsaLocation2Business == null)
            {
                return NotFound();
            }

            return jsaLocation2Business;
        }

        // PUT: api/JsaLocation2Business/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaLocation2Business(int id, JsaLocation2Business jsaLocation2Business)
        {
            if (id != jsaLocation2Business.L2bId)
            {
                return BadRequest();
            }

            _context.Entry(jsaLocation2Business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaLocation2BusinessExists(id))
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

        // POST: api/JsaLocation2Business
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaLocation2Business>> PostJsaLocation2Business(JsaLocation2Business jsaLocation2Business)
        {
            _context.JsaLocation2Businesses.Add(jsaLocation2Business);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaLocation2BusinessExists(jsaLocation2Business.L2bId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaLocation2Business", new { id = jsaLocation2Business.L2bId }, jsaLocation2Business);
        }

        // DELETE: api/JsaLocation2Business/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaLocation2Business(int id)
        {
            var jsaLocation2Business = await _context.JsaLocation2Businesses.FindAsync(id);
            if (jsaLocation2Business == null)
            {
                return NotFound();
            }

            _context.JsaLocation2Businesses.Remove(jsaLocation2Business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaLocation2BusinessExists(int id)
        {
            return _context.JsaLocation2Businesses.Any(e => e.L2bId == id);
        }
    }
}
