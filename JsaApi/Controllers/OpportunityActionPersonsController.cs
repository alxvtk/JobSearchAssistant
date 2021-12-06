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
    public class OpportunityActionPersonsController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public OpportunityActionPersonsController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunityActionPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunityActionPerson>>> GetJsaOpportunityActionPeople()
        {
            return await _context.JsaOpportunityActionPeople.ToListAsync();
        }

        // GET: api/JsaOpportunityActionPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunityActionPerson>> GetJsaOpportunityActionPerson(int id)
        {
            var jsaOpportunityActionPerson = await _context.JsaOpportunityActionPeople.FindAsync(id);

            if (jsaOpportunityActionPerson == null)
            {
                return NotFound();
            }

            return jsaOpportunityActionPerson;
        }

        // PUT: api/JsaOpportunityActionPersons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunityActionPerson(int id, JsaOpportunityActionPerson jsaOpportunityActionPerson)
        {
            if (id != jsaOpportunityActionPerson.OapId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunityActionPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityActionPersonExists(id))
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

        // POST: api/JsaOpportunityActionPersons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunityActionPerson>> PostJsaOpportunityActionPerson(JsaOpportunityActionPerson jsaOpportunityActionPerson)
        {
            _context.JsaOpportunityActionPeople.Add(jsaOpportunityActionPerson);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityActionPersonExists(jsaOpportunityActionPerson.OapId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunityActionPerson", new { id = jsaOpportunityActionPerson.OapId }, jsaOpportunityActionPerson);
        }

        // DELETE: api/JsaOpportunityActionPersons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunityActionPerson(int id)
        {
            var jsaOpportunityActionPerson = await _context.JsaOpportunityActionPeople.FindAsync(id);
            if (jsaOpportunityActionPerson == null)
            {
                return NotFound();
            }

            _context.JsaOpportunityActionPeople.Remove(jsaOpportunityActionPerson);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityActionPersonExists(int id)
        {
            return _context.JsaOpportunityActionPeople.Any(e => e.OapId == id);
        }
    }
}
