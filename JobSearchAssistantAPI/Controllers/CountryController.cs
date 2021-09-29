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
    /// Endpoint to interact with Countries
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;


        public CountryController(ICountryRepository countryRepository, ILoggerService logger, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all countries
        /// </summary>
        /// <returns>List of countries</returns>
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            try
            {
                _logger.LogInfo("Attempted to get all countries");
                var countries = await _countryRepository.FindAll();
                var response = _mapper.Map<IList<CountryDto>>(countries);
                _logger.LogInfo("Successfully got all countries");
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
