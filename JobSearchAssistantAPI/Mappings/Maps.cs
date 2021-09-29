using AutoMapper;
using JobSearchAssistantAPI.Data;
using JobSearchAssistantAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.Mappings
{
    public class Maps: Profile
    {
        public Maps()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            //CreateMap<Business, BusinessDto>().ReverseMap();
            //CreateMap<Location2Business, Location2BusinessDto>().ReverseMap();

        }

    }
}
