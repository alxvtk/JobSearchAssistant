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
    public class JsaEmailController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaEmailController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaEmails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaEmail>>> GetJsaEmails()
        {
            return await _context.JsaEmails.ToListAsync();
        }

        // GET: api/JsaEmails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaEmail>> GetJsaEmail(int id)
        {
            var jsaEmail = await _context.JsaEmails.FindAsync(id);

            if (jsaEmail == null)
            {
                return NotFound();
            }

            return jsaEmail;
        }

        // PUT: api/JsaEmails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaEmail(int id, JsaEmail jsaEmail)
        {
            if (id != jsaEmail.EId)
            {
                return BadRequest();
            }

            _context.Entry(jsaEmail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaEmailExists(id))
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

        // POST: api/JsaEmails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaEmail>> PostJsaEmail(JsaEmail jsaEmail)
        {
            _context.JsaEmails.Add(jsaEmail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaEmailExists(jsaEmail.EId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaEmail", new { id = jsaEmail.EId }, jsaEmail);
        }

        // DELETE: api/JsaEmails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaEmail(int id)
        {
            var jsaEmail = await _context.JsaEmails.FindAsync(id);
            if (jsaEmail == null)
            {
                return NotFound();
            }

            _context.JsaEmails.Remove(jsaEmail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaEmailExists(int id)
        {
            return _context.JsaEmails.Any(e => e.EId == id);
        }
    }
}
