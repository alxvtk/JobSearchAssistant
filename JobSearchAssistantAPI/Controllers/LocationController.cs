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
    /// Endpoint to interact with Locations
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;


        public LocationController(ILocationRepository locationRepository, ILoggerService logger, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all locations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            try
            {
                _logger.LogInfo("Attempted to get all businesses");
                var locations = await _locationRepository.FindAll();
                var response = _mapper.Map<IList<LocationDto>>(locations);
                _logger.LogInfo("Successfully got all locations");
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
