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
    public class Person2BusinessController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public Person2BusinessController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaPerson2Business
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaPerson2Business>>> GetJsaPerson2Businesses()
        {
            return await _context.JsaPerson2Businesses.ToListAsync();
        }

        // GET: api/JsaPerson2Business/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaPerson2Business>> GetJsaPerson2Business(int id)
        {
            var jsaPerson2Business = await _context.JsaPerson2Businesses.FindAsync(id);

            if (jsaPerson2Business == null)
            {
                return NotFound();
            }

            return jsaPerson2Business;
        }

        // PUT: api/JsaPerson2Business/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaPerson2Business(int id, JsaPerson2Business jsaPerson2Business)
        {
            if (id != jsaPerson2Business.P2bId)
            {
                return BadRequest();
            }

            _context.Entry(jsaPerson2Business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaPerson2BusinessExists(id))
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

        // POST: api/JsaPerson2Business
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaPerson2Business>> PostJsaPerson2Business(JsaPerson2Business jsaPerson2Business)
        {
            _context.JsaPerson2Businesses.Add(jsaPerson2Business);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaPerson2BusinessExists(jsaPerson2Business.P2bId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaPerson2Business", new { id = jsaPerson2Business.P2bId }, jsaPerson2Business);
        }

        // DELETE: api/JsaPerson2Business/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaPerson2Business(int id)
        {
            var jsaPerson2Business = await _context.JsaPerson2Businesses.FindAsync(id);
            if (jsaPerson2Business == null)
            {
                return NotFound();
            }

            _context.JsaPerson2Businesses.Remove(jsaPerson2Business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaPerson2BusinessExists(int id)
        {
            return _context.JsaPerson2Businesses.Any(e => e.P2bId == id);
        }
    }
}
