using JobSearchAssistantAPI.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobSearchAssistantAPI.Controllers
{
    /* https://localhost:44371/swagger/v1/swagger.json */
    /* https://localhost:44371/swagger/index.html */
    /// <summary>
    /// This is a test API controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;
        public HomeController(ILoggerService logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Gets Values
        /// </summary>
        /// <returns></returns>
        // GET: api/jsa
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Accessed Home Controller");
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/jsa/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            _logger.LogDebug("Got A Value");
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST api/jsa
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogError("This is an error");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/jsa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <param name="id"></param>
        // DELETE api/jsa/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarn("This is a warning");
        }
    }
}
