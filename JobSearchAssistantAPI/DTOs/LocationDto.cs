using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.DTOs
{
    public class LocationDto
    {
        public int Id { get; set; }

        public string StreetNumber { get; set; }
        public string StreetNumberSuffix { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetDirection { get; set; }
        public string StreetUnit { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Comments { get; set; }
        public virtual CountryDto Country { get; set; }

    }
}
