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
    public class JsaCountriesController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaCountriesController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaCountries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaCountry>>> GetJsaCountries()
        {
            return await _context.JsaCountries.ToListAsync();
        }

        // GET: api/JsaCountries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaCountry>> GetJsaCountry(int id)
        {
            var jsaCountry = await _context.JsaCountries.FindAsync(id);

            if (jsaCountry == null)
            {
                return NotFound();
            }

            return jsaCountry;
        }

        // PUT: api/JsaCountries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaCountry(int id, JsaCountry jsaCountry)
        {
            if (id != jsaCountry.CId)
            {
                return BadRequest();
            }

            _context.Entry(jsaCountry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaCountryExists(id))
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

        // POST: api/JsaCountries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaCountry>> PostJsaCountry(JsaCountry jsaCountry)
        {
            _context.JsaCountries.Add(jsaCountry);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaCountryExists(jsaCountry.CId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaCountry", new { id = jsaCountry.CId }, jsaCountry);
        }

        // DELETE: api/JsaCountries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaCountry(int id)
        {
            var jsaCountry = await _context.JsaCountries.FindAsync(id);
            if (jsaCountry == null)
            {
                return NotFound();
            }

            _context.JsaCountries.Remove(jsaCountry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaCountryExists(int id)
        {
            return _context.JsaCountries.Any(e => e.CId == id);
        }
    }
}
