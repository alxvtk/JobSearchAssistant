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
    public class JsaUrlsController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaUrlsController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaUrls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaUrl>>> GetJsaUrls()
        {
            return await _context.JsaUrls.ToListAsync();
        }

        // GET: api/JsaUrls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaUrl>> GetJsaUrl(int id)
        {
            var jsaUrl = await _context.JsaUrls.FindAsync(id);

            if (jsaUrl == null)
            {
                return NotFound();
            }

            return jsaUrl;
        }

        // PUT: api/JsaUrls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaUrl(int id, JsaUrl jsaUrl)
        {
            if (id != jsaUrl.UId)
            {
                return BadRequest();
            }

            _context.Entry(jsaUrl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaUrlExists(id))
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

        // POST: api/JsaUrls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaUrl>> PostJsaUrl(JsaUrl jsaUrl)
        {
            _context.JsaUrls.Add(jsaUrl);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaUrlExists(jsaUrl.UId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaUrl", new { id = jsaUrl.UId }, jsaUrl);
        }

        // DELETE: api/JsaUrls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaUrl(int id)
        {
            var jsaUrl = await _context.JsaUrls.FindAsync(id);
            if (jsaUrl == null)
            {
                return NotFound();
            }

            _context.JsaUrls.Remove(jsaUrl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaUrlExists(int id)
        {
            return _context.JsaUrls.Any(e => e.UId == id);
        }
    }
}
