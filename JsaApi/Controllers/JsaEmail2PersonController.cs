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
    public class JsaEmail2PersonController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaEmail2PersonController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaEmail2Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaEmail2Person>>> GetJsaEmail2People()
        {
            return await _context.JsaEmail2People.ToListAsync();
        }

        // GET: api/JsaEmail2Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaEmail2Person>> GetJsaEmail2Person(int id)
        {
            var jsaEmail2Person = await _context.JsaEmail2People.FindAsync(id);

            if (jsaEmail2Person == null)
            {
                return NotFound();
            }

            return jsaEmail2Person;
        }

        // PUT: api/JsaEmail2Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaEmail2Person(int id, JsaEmail2Person jsaEmail2Person)
        {
            if (id != jsaEmail2Person.E2pId)
            {
                return BadRequest();
            }

            _context.Entry(jsaEmail2Person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaEmail2PersonExists(id))
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

        // POST: api/JsaEmail2Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaEmail2Person>> PostJsaEmail2Person(JsaEmail2Person jsaEmail2Person)
        {
            _context.JsaEmail2People.Add(jsaEmail2Person);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaEmail2PersonExists(jsaEmail2Person.E2pId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaEmail2Person", new { id = jsaEmail2Person.E2pId }, jsaEmail2Person);
        }

        // DELETE: api/JsaEmail2Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaEmail2Person(int id)
        {
            var jsaEmail2Person = await _context.JsaEmail2People.FindAsync(id);
            if (jsaEmail2Person == null)
            {
                return NotFound();
            }

            _context.JsaEmail2People.Remove(jsaEmail2Person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaEmail2PersonExists(int id)
        {
            return _context.JsaEmail2People.Any(e => e.E2pId == id);
        }
    }
}
