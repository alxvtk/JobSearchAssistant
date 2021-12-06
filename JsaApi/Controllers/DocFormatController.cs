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
    public class DocFormatController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public DocFormatController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaDocFormats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaDocFormat>>> GetJsaDocFormats()
        {
            return await _context.JsaDocFormats.ToListAsync();
        }

        // GET: api/JsaDocFormats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaDocFormat>> GetJsaDocFormat(int id)
        {
            var jsaDocFormat = await _context.JsaDocFormats.FindAsync(id);

            if (jsaDocFormat == null)
            {
                return NotFound();
            }

            return jsaDocFormat;
        }

        // PUT: api/JsaDocFormats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaDocFormat(int id, JsaDocFormat jsaDocFormat)
        {
            if (id != jsaDocFormat.DfId)
            {
                return BadRequest();
            }

            _context.Entry(jsaDocFormat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaDocFormatExists(id))
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

        // POST: api/JsaDocFormats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaDocFormat>> PostJsaDocFormat(JsaDocFormat jsaDocFormat)
        {
            _context.JsaDocFormats.Add(jsaDocFormat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaDocFormatExists(jsaDocFormat.DfId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaDocFormat", new { id = jsaDocFormat.DfId }, jsaDocFormat);
        }

        // DELETE: api/JsaDocFormats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaDocFormat(int id)
        {
            var jsaDocFormat = await _context.JsaDocFormats.FindAsync(id);
            if (jsaDocFormat == null)
            {
                return NotFound();
            }

            _context.JsaDocFormats.Remove(jsaDocFormat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaDocFormatExists(int id)
        {
            return _context.JsaDocFormats.Any(e => e.DfId == id);
        }
    }
}
