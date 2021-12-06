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
    public class Phone2PersonController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public Phone2PersonController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaPhone2Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaPhone2Person>>> GetJsaPhone2People()
        {
            return await _context.JsaPhone2People.ToListAsync();
        }

        // GET: api/JsaPhone2Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaPhone2Person>> GetJsaPhone2Person(int id)
        {
            var jsaPhone2Person = await _context.JsaPhone2People.FindAsync(id);

            if (jsaPhone2Person == null)
            {
                return NotFound();
            }

            return jsaPhone2Person;
        }

        // PUT: api/JsaPhone2Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaPhone2Person(int id, JsaPhone2Person jsaPhone2Person)
        {
            if (id != jsaPhone2Person.Ph2pId)
            {
                return BadRequest();
            }

            _context.Entry(jsaPhone2Person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaPhone2PersonExists(id))
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

        // POST: api/JsaPhone2Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaPhone2Person>> PostJsaPhone2Person(JsaPhone2Person jsaPhone2Person)
        {
            _context.JsaPhone2People.Add(jsaPhone2Person);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaPhone2PersonExists(jsaPhone2Person.Ph2pId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaPhone2Person", new { id = jsaPhone2Person.Ph2pId }, jsaPhone2Person);
        }

        // DELETE: api/JsaPhone2Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaPhone2Person(int id)
        {
            var jsaPhone2Person = await _context.JsaPhone2People.FindAsync(id);
            if (jsaPhone2Person == null)
            {
                return NotFound();
            }

            _context.JsaPhone2People.Remove(jsaPhone2Person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaPhone2PersonExists(int id)
        {
            return _context.JsaPhone2People.Any(e => e.Ph2pId == id);
        }
    }
}
