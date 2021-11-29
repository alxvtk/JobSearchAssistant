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
    public class JsaResumeController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaResumeController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaResumes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaResume>>> GetJsaResumes()
        {
            return await _context.JsaResumes.ToListAsync();
        }

        // GET: api/JsaResumes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaResume>> GetJsaResume(int id)
        {
            var jsaResume = await _context.JsaResumes.FindAsync(id);

            if (jsaResume == null)
            {
                return NotFound();
            }

            return jsaResume;
        }

        // PUT: api/JsaResumes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaResume(int id, JsaResume jsaResume)
        {
            if (id != jsaResume.RId)
            {
                return BadRequest();
            }

            _context.Entry(jsaResume).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaResumeExists(id))
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

        // POST: api/JsaResumes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaResume>> PostJsaResume(JsaResume jsaResume)
        {
            _context.JsaResumes.Add(jsaResume);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaResumeExists(jsaResume.RId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaResume", new { id = jsaResume.RId }, jsaResume);
        }

        // DELETE: api/JsaResumes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaResume(int id)
        {
            var jsaResume = await _context.JsaResumes.FindAsync(id);
            if (jsaResume == null)
            {
                return NotFound();
            }

            _context.JsaResumes.Remove(jsaResume);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaResumeExists(int id)
        {
            return _context.JsaResumes.Any(e => e.RId == id);
        }
    }
}
