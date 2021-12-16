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
    public class JsaPhone2BusinessController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaPhone2BusinessController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaPhone2Business
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaPhone2Business>>> GetJsaPhone2Businesses()
        {
            return await _context.JsaPhone2Businesses.ToListAsync();
        }

        // GET: api/JsaPhone2Business/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaPhone2Business>> GetJsaPhone2Business(int id)
        {
            var jsaPhone2Business = await _context.JsaPhone2Businesses.FindAsync(id);

            if (jsaPhone2Business == null)
            {
                return NotFound();
            }

            return jsaPhone2Business;
        }

        // PUT: api/JsaPhone2Business/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaPhone2Business(int id, JsaPhone2Business jsaPhone2Business)
        {
            if (id != jsaPhone2Business.Ph2bId)
            {
                return BadRequest();
            }

            _context.Entry(jsaPhone2Business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaPhone2BusinessExists(id))
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

        // POST: api/JsaPhone2Business
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaPhone2Business>> PostJsaPhone2Business(JsaPhone2Business jsaPhone2Business)
        {
            _context.JsaPhone2Businesses.Add(jsaPhone2Business);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaPhone2BusinessExists(jsaPhone2Business.Ph2bId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaPhone2Business", new { id = jsaPhone2Business.Ph2bId }, jsaPhone2Business);
        }

        // DELETE: api/JsaPhone2Business/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaPhone2Business(int id)
        {
            var jsaPhone2Business = await _context.JsaPhone2Businesses.FindAsync(id);
            if (jsaPhone2Business == null)
            {
                return NotFound();
            }

            _context.JsaPhone2Businesses.Remove(jsaPhone2Business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaPhone2BusinessExists(int id)
        {
            return _context.JsaPhone2Businesses.Any(e => e.Ph2bId == id);
        }
    }
}
