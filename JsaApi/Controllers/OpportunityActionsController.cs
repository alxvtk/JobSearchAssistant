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
    public class OpportunityActionsController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public OpportunityActionsController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunityActions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunityAction>>> GetJsaOpportunityActions()
        {
            return await _context.JsaOpportunityActions.ToListAsync();
        }

        // GET: api/JsaOpportunityActions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunityAction>> GetJsaOpportunityAction(int id)
        {
            var jsaOpportunityAction = await _context.JsaOpportunityActions.FindAsync(id);

            if (jsaOpportunityAction == null)
            {
                return NotFound();
            }

            return jsaOpportunityAction;
        }

        // PUT: api/JsaOpportunityActions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunityAction(int id, JsaOpportunityAction jsaOpportunityAction)
        {
            if (id != jsaOpportunityAction.OaId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunityAction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityActionExists(id))
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

        // POST: api/JsaOpportunityActions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunityAction>> PostJsaOpportunityAction(JsaOpportunityAction jsaOpportunityAction)
        {
            _context.JsaOpportunityActions.Add(jsaOpportunityAction);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityActionExists(jsaOpportunityAction.OaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunityAction", new { id = jsaOpportunityAction.OaId }, jsaOpportunityAction);
        }

        // DELETE: api/JsaOpportunityActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunityAction(int id)
        {
            var jsaOpportunityAction = await _context.JsaOpportunityActions.FindAsync(id);
            if (jsaOpportunityAction == null)
            {
                return NotFound();
            }

            _context.JsaOpportunityActions.Remove(jsaOpportunityAction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityActionExists(int id)
        {
            return _context.JsaOpportunityActions.Any(e => e.OaId == id);
        }
    }
}
