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
    public class Email2BusinessController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public Email2BusinessController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaEmail2Business
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaEmail2Business>>> GetJsaEmail2Businesses()
        {
            return await _context.JsaEmail2Businesses.ToListAsync();
        }

        // GET: api/JsaEmail2Business/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaEmail2Business>> GetJsaEmail2Business(int id)
        {
            var jsaEmail2Business = await _context.JsaEmail2Businesses.FindAsync(id);

            if (jsaEmail2Business == null)
            {
                return NotFound();
            }

            return jsaEmail2Business;
        }

        // PUT: api/JsaEmail2Business/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaEmail2Business(int id, JsaEmail2Business jsaEmail2Business)
        {
            if (id != jsaEmail2Business.E2bId)
            {
                return BadRequest();
            }

            _context.Entry(jsaEmail2Business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaEmail2BusinessExists(id))
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

        // POST: api/JsaEmail2Business
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaEmail2Business>> PostJsaEmail2Business(JsaEmail2Business jsaEmail2Business)
        {
            _context.JsaEmail2Businesses.Add(jsaEmail2Business);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaEmail2BusinessExists(jsaEmail2Business.E2bId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaEmail2Business", new { id = jsaEmail2Business.E2bId }, jsaEmail2Business);
        }

        // DELETE: api/JsaEmail2Business/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaEmail2Business(int id)
        {
            var jsaEmail2Business = await _context.JsaEmail2Businesses.FindAsync(id);
            if (jsaEmail2Business == null)
            {
                return NotFound();
            }

            _context.JsaEmail2Businesses.Remove(jsaEmail2Business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaEmail2BusinessExists(int id)
        {
            return _context.JsaEmail2Businesses.Any(e => e.E2bId == id);
        }
    }
}
