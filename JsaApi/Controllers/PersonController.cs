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
    public class PersonController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public PersonController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaPerson>>> GetJsaPeople()
        {
            return await _context.JsaPeople.ToListAsync();
        }

        // GET: api/JsaPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaPerson>> GetJsaPerson(int id)
        {
            var jsaPerson = await _context.JsaPeople.FindAsync(id);

            if (jsaPerson == null)
            {
                return NotFound();
            }

            return jsaPerson;
        }

        // PUT: api/JsaPersons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaPerson(int id, JsaPerson jsaPerson)
        {
            if (id != jsaPerson.PId)
            {
                return BadRequest();
            }

            _context.Entry(jsaPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaPersonExists(id))
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

        // POST: api/JsaPersons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaPerson>> PostJsaPerson(JsaPerson jsaPerson)
        {
            _context.JsaPeople.Add(jsaPerson);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaPersonExists(jsaPerson.PId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaPerson", new { id = jsaPerson.PId }, jsaPerson);
        }

        // DELETE: api/JsaPersons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaPerson(int id)
        {
            var jsaPerson = await _context.JsaPeople.FindAsync(id);
            if (jsaPerson == null)
            {
                return NotFound();
            }

            _context.JsaPeople.Remove(jsaPerson);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaPersonExists(int id)
        {
            return _context.JsaPeople.Any(e => e.PId == id);
        }
    }
}
