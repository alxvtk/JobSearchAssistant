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
    public class JsaBusinessController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaBusinessController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaBusinesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaBusiness>>> GetJsaBusinesses()
        {
            return await _context.JsaBusinesses.ToListAsync();
        }

        // GET: api/JsaBusinesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaBusiness>> GetJsaBusiness(int id)
        {
            var jsaBusiness = await _context.JsaBusinesses.FindAsync(id);

            if (jsaBusiness == null)
            {
                return NotFound();
            }

            return jsaBusiness;
        }

        // PUT: api/JsaBusinesses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaBusiness(int id, JsaBusiness jsaBusiness)
        {
            if (id != jsaBusiness.BId)
            {
                return BadRequest();
            }

            _context.Entry(jsaBusiness).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaBusinessExists(id))
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

        // POST: api/JsaBusinesses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaBusiness>> PostJsaBusiness(JsaBusiness jsaBusiness)
        {
            _context.JsaBusinesses.Add(jsaBusiness);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaBusinessExists(jsaBusiness.BId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaBusiness", new { id = jsaBusiness.BId }, jsaBusiness);
        }

        // DELETE: api/JsaBusinesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaBusiness(int id)
        {
            var jsaBusiness = await _context.JsaBusinesses.FindAsync(id);
            if (jsaBusiness == null)
            {
                return NotFound();
            }

            _context.JsaBusinesses.Remove(jsaBusiness);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaBusinessExists(int id)
        {
            return _context.JsaBusinesses.Any(e => e.BId == id);
        }
    }
}
