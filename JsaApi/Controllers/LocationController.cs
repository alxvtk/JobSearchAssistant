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
    public class LocationController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public LocationController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaLocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaLocation>>> GetJsaLocations()
        {
            return await _context.JsaLocations.ToListAsync();
        }

        // GET: api/JsaLocations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaLocation>> GetJsaLocation(int id)
        {
            var jsaLocation = await _context.JsaLocations.FindAsync(id);

            if (jsaLocation == null)
            {
                return NotFound();
            }

            return jsaLocation;
        }

        // PUT: api/JsaLocations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaLocation(int id, JsaLocation jsaLocation)
        {
            if (id != jsaLocation.LId)
            {
                return BadRequest();
            }

            _context.Entry(jsaLocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaLocationExists(id))
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

        // POST: api/JsaLocations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaLocation>> PostJsaLocation(JsaLocation jsaLocation)
        {
            _context.JsaLocations.Add(jsaLocation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaLocationExists(jsaLocation.LId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaLocation", new { id = jsaLocation.LId }, jsaLocation);
        }

        // DELETE: api/JsaLocations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaLocation(int id)
        {
            var jsaLocation = await _context.JsaLocations.FindAsync(id);
            if (jsaLocation == null)
            {
                return NotFound();
            }

            _context.JsaLocations.Remove(jsaLocation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaLocationExists(int id)
        {
            return _context.JsaLocations.Any(e => e.LId == id);
        }
    }
}
