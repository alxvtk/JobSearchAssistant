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
    public class OpportunityWorkflowActionController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public OpportunityWorkflowActionController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunityWorkflowActions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunityWorkflowAction>>> GetJsaOpportunityWorkflowActions()
        {
            return await _context.JsaOpportunityWorkflowActions.ToListAsync();
        }

        // GET: api/JsaOpportunityWorkflowActions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunityWorkflowAction>> GetJsaOpportunityWorkflowAction(int id)
        {
            var jsaOpportunityWorkflowAction = await _context.JsaOpportunityWorkflowActions.FindAsync(id);

            if (jsaOpportunityWorkflowAction == null)
            {
                return NotFound();
            }

            return jsaOpportunityWorkflowAction;
        }

        // PUT: api/JsaOpportunityWorkflowActions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunityWorkflowAction(int id, JsaOpportunityWorkflowAction jsaOpportunityWorkflowAction)
        {
            if (id != jsaOpportunityWorkflowAction.OwaId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunityWorkflowAction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityWorkflowActionExists(id))
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

        // POST: api/JsaOpportunityWorkflowActions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunityWorkflowAction>> PostJsaOpportunityWorkflowAction(JsaOpportunityWorkflowAction jsaOpportunityWorkflowAction)
        {
            _context.JsaOpportunityWorkflowActions.Add(jsaOpportunityWorkflowAction);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityWorkflowActionExists(jsaOpportunityWorkflowAction.OwaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunityWorkflowAction", new { id = jsaOpportunityWorkflowAction.OwaId }, jsaOpportunityWorkflowAction);
        }

        // DELETE: api/JsaOpportunityWorkflowActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunityWorkflowAction(int id)
        {
            var jsaOpportunityWorkflowAction = await _context.JsaOpportunityWorkflowActions.FindAsync(id);
            if (jsaOpportunityWorkflowAction == null)
            {
                return NotFound();
            }

            _context.JsaOpportunityWorkflowActions.Remove(jsaOpportunityWorkflowAction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityWorkflowActionExists(int id)
        {
            return _context.JsaOpportunityWorkflowActions.Any(e => e.OwaId == id);
        }
    }
}
