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
    public class JsaResultStatusController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaResultStatusController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaResultStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaResultStatus>>> GetJsaResultStatuses()
        {
            return await _context.JsaResultStatuses.ToListAsync();
        }

        // GET: api/JsaResultStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaResultStatus>> GetJsaResultStatus(int id)
        {
            var jsaResultStatus = await _context.JsaResultStatuses.FindAsync(id);

            if (jsaResultStatus == null)
            {
                return NotFound();
            }

            return jsaResultStatus;
        }

        // PUT: api/JsaResultStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaResultStatus(int id, JsaResultStatus jsaResultStatus)
        {
            if (id != jsaResultStatus.RsId)
            {
                return BadRequest();
            }

            _context.Entry(jsaResultStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaResultStatusExists(id))
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

        // POST: api/JsaResultStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaResultStatus>> PostJsaResultStatus(JsaResultStatus jsaResultStatus)
        {
            _context.JsaResultStatuses.Add(jsaResultStatus);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaResultStatusExists(jsaResultStatus.RsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaResultStatus", new { id = jsaResultStatus.RsId }, jsaResultStatus);
        }

        // DELETE: api/JsaResultStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaResultStatus(int id)
        {
            var jsaResultStatus = await _context.JsaResultStatuses.FindAsync(id);
            if (jsaResultStatus == null)
            {
                return NotFound();
            }

            _context.JsaResultStatuses.Remove(jsaResultStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaResultStatusExists(int id)
        {
            return _context.JsaResultStatuses.Any(e => e.RsId == id);
        }
    }
}
