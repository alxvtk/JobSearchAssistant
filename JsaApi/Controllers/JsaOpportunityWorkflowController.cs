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
    public class JsaOpportunityWorkflowController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaOpportunityWorkflowController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunityWorkflows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunityWorkflow>>> GetJsaOpportunityWorkflows()
        {
            return await _context.JsaOpportunityWorkflows.ToListAsync();
        }

        // GET: api/JsaOpportunityWorkflows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunityWorkflow>> GetJsaOpportunityWorkflow(int id)
        {
            var jsaOpportunityWorkflow = await _context.JsaOpportunityWorkflows.FindAsync(id);

            if (jsaOpportunityWorkflow == null)
            {
                return NotFound();
            }

            return jsaOpportunityWorkflow;
        }

        // PUT: api/JsaOpportunityWorkflows/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunityWorkflow(int id, JsaOpportunityWorkflow jsaOpportunityWorkflow)
        {
            if (id != jsaOpportunityWorkflow.OwId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunityWorkflow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityWorkflowExists(id))
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

        // POST: api/JsaOpportunityWorkflows
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunityWorkflow>> PostJsaOpportunityWorkflow(JsaOpportunityWorkflow jsaOpportunityWorkflow)
        {
            _context.JsaOpportunityWorkflows.Add(jsaOpportunityWorkflow);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityWorkflowExists(jsaOpportunityWorkflow.OwId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunityWorkflow", new { id = jsaOpportunityWorkflow.OwId }, jsaOpportunityWorkflow);
        }

        // DELETE: api/JsaOpportunityWorkflows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunityWorkflow(int id)
        {
            var jsaOpportunityWorkflow = await _context.JsaOpportunityWorkflows.FindAsync(id);
            if (jsaOpportunityWorkflow == null)
            {
                return NotFound();
            }

            _context.JsaOpportunityWorkflows.Remove(jsaOpportunityWorkflow);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityWorkflowExists(int id)
        {
            return _context.JsaOpportunityWorkflows.Any(e => e.OwId == id);
        }
    }
}
