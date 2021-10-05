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
    public class JsaUsersController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaUsersController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaUser>>> GetJsaUsers()
        {
            return await _context.JsaUsers.ToListAsync();
        }

        // GET: api/JsaUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaUser>> GetJsaUser(int id)
        {
            var jsaUser = await _context.JsaUsers.FindAsync(id);

            if (jsaUser == null)
            {
                return NotFound();
            }

            return jsaUser;
        }

        // PUT: api/JsaUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaUser(int id, JsaUser jsaUser)
        {
            if (id != jsaUser.UsrId)
            {
                return BadRequest();
            }

            _context.Entry(jsaUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaUserExists(id))
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

        // POST: api/JsaUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaUser>> PostJsaUser(JsaUser jsaUser)
        {
            _context.JsaUsers.Add(jsaUser);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaUserExists(jsaUser.UsrId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaUser", new { id = jsaUser.UsrId }, jsaUser);
        }

        // DELETE: api/JsaUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaUser(int id)
        {
            var jsaUser = await _context.JsaUsers.FindAsync(id);
            if (jsaUser == null)
            {
                return NotFound();
            }

            _context.JsaUsers.Remove(jsaUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaUserExists(int id)
        {
            return _context.JsaUsers.Any(e => e.UsrId == id);
        }
    }
}
