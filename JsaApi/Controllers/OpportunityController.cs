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
    public class OpportunityController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public OpportunityController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunity>>> GetJsaOpportunities()
        {
            return await _context.JsaOpportunities.ToListAsync();
        }

        // GET: api/JsaOpportunities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunity>> GetJsaOpportunity(int id)
        {
            var jsaOpportunity = await _context.JsaOpportunities.FindAsync(id);

            if (jsaOpportunity == null)
            {
                return NotFound();
            }

            return jsaOpportunity;
        }

        // PUT: api/JsaOpportunities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunity(int id, JsaOpportunity jsaOpportunity)
        {
            if (id != jsaOpportunity.OId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityExists(id))
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

        // POST: api/JsaOpportunities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunity>> PostJsaOpportunity(JsaOpportunity jsaOpportunity)
        {
            _context.JsaOpportunities.Add(jsaOpportunity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityExists(jsaOpportunity.OId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunity", new { id = jsaOpportunity.OId }, jsaOpportunity);
        }

        // DELETE: api/JsaOpportunities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunity(int id)
        {
            var jsaOpportunity = await _context.JsaOpportunities.FindAsync(id);
            if (jsaOpportunity == null)
            {
                return NotFound();
            }

            _context.JsaOpportunities.Remove(jsaOpportunity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityExists(int id)
        {
            return _context.JsaOpportunities.Any(e => e.OId == id);
        }
    }
}
