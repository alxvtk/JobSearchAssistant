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
    public class Location2PersonController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public Location2PersonController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaLocation2Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaLocation2Person>>> GetJsaLocation2People()
        {
            return await _context.JsaLocation2People.ToListAsync();
        }

        // GET: api/JsaLocation2Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaLocation2Person>> GetJsaLocation2Person(int id)
        {
            var jsaLocation2Person = await _context.JsaLocation2People.FindAsync(id);

            if (jsaLocation2Person == null)
            {
                return NotFound();
            }

            return jsaLocation2Person;
        }

        // PUT: api/JsaLocation2Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaLocation2Person(int id, JsaLocation2Person jsaLocation2Person)
        {
            if (id != jsaLocation2Person.L2pId)
            {
                return BadRequest();
            }

            _context.Entry(jsaLocation2Person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaLocation2PersonExists(id))
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

        // POST: api/JsaLocation2Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaLocation2Person>> PostJsaLocation2Person(JsaLocation2Person jsaLocation2Person)
        {
            _context.JsaLocation2People.Add(jsaLocation2Person);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaLocation2PersonExists(jsaLocation2Person.L2pId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaLocation2Person", new { id = jsaLocation2Person.L2pId }, jsaLocation2Person);
        }

        // DELETE: api/JsaLocation2Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaLocation2Person(int id)
        {
            var jsaLocation2Person = await _context.JsaLocation2People.FindAsync(id);
            if (jsaLocation2Person == null)
            {
                return NotFound();
            }

            _context.JsaLocation2People.Remove(jsaLocation2Person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaLocation2PersonExists(int id)
        {
            return _context.JsaLocation2People.Any(e => e.L2pId == id);
        }
    }
}
