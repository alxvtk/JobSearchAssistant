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
    public class JsaOpportunityActionTypesController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaOpportunityActionTypesController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunityActionTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunityActionType>>> GetJsaOpportunityActionTypes()
        {
            return await _context.JsaOpportunityActionTypes.ToListAsync();
        }

        // GET: api/JsaOpportunityActionTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunityActionType>> GetJsaOpportunityActionType(int id)
        {
            var jsaOpportunityActionType = await _context.JsaOpportunityActionTypes.FindAsync(id);

            if (jsaOpportunityActionType == null)
            {
                return NotFound();
            }

            return jsaOpportunityActionType;
        }

        // PUT: api/JsaOpportunityActionTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunityActionType(int id, JsaOpportunityActionType jsaOpportunityActionType)
        {
            if (id != jsaOpportunityActionType.OatId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunityActionType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityActionTypeExists(id))
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

        // POST: api/JsaOpportunityActionTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunityActionType>> PostJsaOpportunityActionType(JsaOpportunityActionType jsaOpportunityActionType)
        {
            _context.JsaOpportunityActionTypes.Add(jsaOpportunityActionType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityActionTypeExists(jsaOpportunityActionType.OatId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunityActionType", new { id = jsaOpportunityActionType.OatId }, jsaOpportunityActionType);
        }

        // DELETE: api/JsaOpportunityActionTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunityActionType(int id)
        {
            var jsaOpportunityActionType = await _context.JsaOpportunityActionTypes.FindAsync(id);
            if (jsaOpportunityActionType == null)
            {
                return NotFound();
            }

            _context.JsaOpportunityActionTypes.Remove(jsaOpportunityActionType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityActionTypeExists(int id)
        {
            return _context.JsaOpportunityActionTypes.Any(e => e.OatId == id);
        }
    }
}
