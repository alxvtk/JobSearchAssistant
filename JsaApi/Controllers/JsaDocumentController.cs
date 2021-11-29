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
    public class JsaDocumentController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaDocumentController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaDocuments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaDocument>>> GetJsaDocuments()
        {
            return await _context.JsaDocuments.ToListAsync();
        }

        // GET: api/JsaDocuments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaDocument>> GetJsaDocument(int id)
        {
            var jsaDocument = await _context.JsaDocuments.FindAsync(id);

            if (jsaDocument == null)
            {
                return NotFound();
            }

            return jsaDocument;
        }

        // PUT: api/JsaDocuments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaDocument(int id, JsaDocument jsaDocument)
        {
            if (id != jsaDocument.DId)
            {
                return BadRequest();
            }

            _context.Entry(jsaDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaDocumentExists(id))
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

        // POST: api/JsaDocuments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaDocument>> PostJsaDocument(JsaDocument jsaDocument)
        {
            _context.JsaDocuments.Add(jsaDocument);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaDocumentExists(jsaDocument.DId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaDocument", new { id = jsaDocument.DId }, jsaDocument);
        }

        // DELETE: api/JsaDocuments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaDocument(int id)
        {
            var jsaDocument = await _context.JsaDocuments.FindAsync(id);
            if (jsaDocument == null)
            {
                return NotFound();
            }

            _context.JsaDocuments.Remove(jsaDocument);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaDocumentExists(int id)
        {
            return _context.JsaDocuments.Any(e => e.DId == id);
        }
    }
}
