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
    public class PhoneController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public PhoneController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaPhones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaPhone>>> GetJsaPhones()
        {
            return await _context.JsaPhones.ToListAsync();
        }

        // GET: api/JsaPhones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaPhone>> GetJsaPhone(int id)
        {
            var jsaPhone = await _context.JsaPhones.FindAsync(id);

            if (jsaPhone == null)
            {
                return NotFound();
            }

            return jsaPhone;
        }

        // PUT: api/JsaPhones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaPhone(int id, JsaPhone jsaPhone)
        {
            if (id != jsaPhone.PhId)
            {
                return BadRequest();
            }

            _context.Entry(jsaPhone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaPhoneExists(id))
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

        // POST: api/JsaPhones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaPhone>> PostJsaPhone(JsaPhone jsaPhone)
        {
            _context.JsaPhones.Add(jsaPhone);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaPhoneExists(jsaPhone.PhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaPhone", new { id = jsaPhone.PhId }, jsaPhone);
        }

        // DELETE: api/JsaPhones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaPhone(int id)
        {
            var jsaPhone = await _context.JsaPhones.FindAsync(id);
            if (jsaPhone == null)
            {
                return NotFound();
            }

            _context.JsaPhones.Remove(jsaPhone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaPhoneExists(int id)
        {
            return _context.JsaPhones.Any(e => e.PhId == id);
        }
    }
}
