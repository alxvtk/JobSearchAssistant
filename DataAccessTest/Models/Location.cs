using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessTest.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string StreetNumber { get; set; }
        public string StreetNumberSufix { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetDirection { get; set; }
        public string Unit { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public int CountryId { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Comments { get; set; }


        public Country Country { get; set; }
    }
}
