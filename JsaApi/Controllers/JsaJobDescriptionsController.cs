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
    public class JsaJobDescriptionsController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaJobDescriptionsController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaJobDescriptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaJobDescription>>> GetJsaJobDescriptions()
        {
            return await _context.JsaJobDescriptions.ToListAsync();
        }

        // GET: api/JsaJobDescriptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaJobDescription>> GetJsaJobDescription(int id)
        {
            var jsaJobDescription = await _context.JsaJobDescriptions.FindAsync(id);

            if (jsaJobDescription == null)
            {
                return NotFound();
            }

            return jsaJobDescription;
        }

        // PUT: api/JsaJobDescriptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaJobDescription(int id, JsaJobDescription jsaJobDescription)
        {
            if (id != jsaJobDescription.JdId)
            {
                return BadRequest();
            }

            _context.Entry(jsaJobDescription).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaJobDescriptionExists(id))
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

        // POST: api/JsaJobDescriptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaJobDescription>> PostJsaJobDescription(JsaJobDescription jsaJobDescription)
        {
            _context.JsaJobDescriptions.Add(jsaJobDescription);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaJobDescriptionExists(jsaJobDescription.JdId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaJobDescription", new { id = jsaJobDescription.JdId }, jsaJobDescription);
        }

        // DELETE: api/JsaJobDescriptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaJobDescription(int id)
        {
            var jsaJobDescription = await _context.JsaJobDescriptions.FindAsync(id);
            if (jsaJobDescription == null)
            {
                return NotFound();
            }

            _context.JsaJobDescriptions.Remove(jsaJobDescription);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaJobDescriptionExists(int id)
        {
            return _context.JsaJobDescriptions.Any(e => e.JdId == id);
        }
    }
}
