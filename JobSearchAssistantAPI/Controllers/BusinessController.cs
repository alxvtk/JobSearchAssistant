using AutoMapper;
using JobSearchAssistantAPI.Contracts;
using JobSearchAssistantAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.Controllers
{
    /// <summary>
    /// Endpoint to interact with Businesses
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public BusinessController(IBusinessRepository businessRepository, ILoggerService logger, IMapper mapper)
        {
            _businessRepository = businessRepository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all businesses
        /// </summary>
        /// <returns>List of businesses</returns>
        [HttpGet]
        public async Task<IActionResult> GetBusinesses()
        {
            try
            {
                _logger.LogInfo("Attempted to get all businesses");
                var businesses = await _businessRepository.FindAll();
                var response = _mapper.Map<IList<BusinessDto>>(businesses);
                _logger.LogInfo("Successfully got all businesses");
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message} - {e.InnerException}");
                return StatusCode(500, "Something went wrong. Please contact Administrator");
                //throw;
            }
        }
    }
}
