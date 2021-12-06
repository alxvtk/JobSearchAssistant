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
    public class OpportunityDocumentController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public OpportunityDocumentController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaOpportunityDocuments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaOpportunityDocument>>> GetJsaOpportunityDocuments()
        {
            return await _context.JsaOpportunityDocuments.ToListAsync();
        }

        // GET: api/JsaOpportunityDocuments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaOpportunityDocument>> GetJsaOpportunityDocument(int id)
        {
            var jsaOpportunityDocument = await _context.JsaOpportunityDocuments.FindAsync(id);

            if (jsaOpportunityDocument == null)
            {
                return NotFound();
            }

            return jsaOpportunityDocument;
        }

        // PUT: api/JsaOpportunityDocuments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaOpportunityDocument(int id, JsaOpportunityDocument jsaOpportunityDocument)
        {
            if (id != jsaOpportunityDocument.OdId)
            {
                return BadRequest();
            }

            _context.Entry(jsaOpportunityDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaOpportunityDocumentExists(id))
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

        // POST: api/JsaOpportunityDocuments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaOpportunityDocument>> PostJsaOpportunityDocument(JsaOpportunityDocument jsaOpportunityDocument)
        {
            _context.JsaOpportunityDocuments.Add(jsaOpportunityDocument);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaOpportunityDocumentExists(jsaOpportunityDocument.OdId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaOpportunityDocument", new { id = jsaOpportunityDocument.OdId }, jsaOpportunityDocument);
        }

        // DELETE: api/JsaOpportunityDocuments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaOpportunityDocument(int id)
        {
            var jsaOpportunityDocument = await _context.JsaOpportunityDocuments.FindAsync(id);
            if (jsaOpportunityDocument == null)
            {
                return NotFound();
            }

            _context.JsaOpportunityDocuments.Remove(jsaOpportunityDocument);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaOpportunityDocumentExists(int id)
        {
            return _context.JsaOpportunityDocuments.Any(e => e.OdId == id);
        }
    }
}
