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
    public class JsaResultCategoryController : ControllerBase
    {
        private readonly JobSearchAssistantContext _context;

        public JsaResultCategoryController(JobSearchAssistantContext context)
        {
            _context = context;
        }

        // GET: api/JsaResultCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JsaResultCategory>>> GetJsaResultCategories()
        {
            return await _context.JsaResultCategories.ToListAsync();
        }

        // GET: api/JsaResultCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JsaResultCategory>> GetJsaResultCategory(int id)
        {
            var jsaResultCategory = await _context.JsaResultCategories.FindAsync(id);

            if (jsaResultCategory == null)
            {
                return NotFound();
            }

            return jsaResultCategory;
        }

        // PUT: api/JsaResultCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJsaResultCategory(int id, JsaResultCategory jsaResultCategory)
        {
            if (id != jsaResultCategory.RcId)
            {
                return BadRequest();
            }

            _context.Entry(jsaResultCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsaResultCategoryExists(id))
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

        // POST: api/JsaResultCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JsaResultCategory>> PostJsaResultCategory(JsaResultCategory jsaResultCategory)
        {
            _context.JsaResultCategories.Add(jsaResultCategory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JsaResultCategoryExists(jsaResultCategory.RcId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJsaResultCategory", new { id = jsaResultCategory.RcId }, jsaResultCategory);
        }

        // DELETE: api/JsaResultCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJsaResultCategory(int id)
        {
            var jsaResultCategory = await _context.JsaResultCategories.FindAsync(id);
            if (jsaResultCategory == null)
            {
                return NotFound();
            }

            _context.JsaResultCategories.Remove(jsaResultCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JsaResultCategoryExists(int id)
        {
            return _context.JsaResultCategories.Any(e => e.RcId == id);
        }
    }
}
