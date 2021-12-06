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
    public class Url2BusinessController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public Url2BusinessController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaUrl2Business
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaUrl2Business>>> GetJsaUrl2Businesses()
        {
            return await _context.JsaUrl2Businesses.ToListAsync();
        }

        // GET: api/JsaUrl2Business/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaUrl2Business>> GetJsaUrl2Business(int id)
        {
            var jsaUrl2Business = await _context.JsaUrl2Businesses.FindAsync(id);

            if (jsaUrl2Business == null)
            {
                return NotFound();
            }

            return jsaUrl2Business;
        }

        // PUT: api/JsaUrl2Business/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaUrl2Business(int id, JsaUrl2Business jsaUrl2Business)
        {
            if (id != jsaUrl2Business.U2bId)
            {
                return BadRequest();
            }

            _context.Entry(jsaUrl2Business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaUrl2BusinessExists(id))
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

        // POST: api/JsaUrl2Business
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaUrl2Business>> PostJsaUrl2Business(JsaUrl2Business jsaUrl2Business)
        {
            _context.JsaUrl2Businesses.Add(jsaUrl2Business);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaUrl2BusinessExists(jsaUrl2Business.U2bId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaUrl2Business", new { id = jsaUrl2Business.U2bId }, jsaUrl2Business);
        }

        // DELETE: api/JsaUrl2Business/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaUrl2Business(int id)
        {
            var jsaUrl2Business = await _context.JsaUrl2Businesses.FindAsync(id);
            if (jsaUrl2Business == null)
            {
                return NotFound();
            }

            _context.JsaUrl2Businesses.Remove(jsaUrl2Business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaUrl2BusinessExists(int id)
        {
            return _context.JsaUrl2Businesses.Any(e => e.U2bId == id);
        }
    }
}
