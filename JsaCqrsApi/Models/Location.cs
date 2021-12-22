using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Location
    {
        public Location()
        {
            Location2Businesses = new HashSet<Location2Business>();
            Location2People = new HashSet<Location2Person>();
        }

        public int Id { get; set; }
        public string StreetNumber { get; set; }
        public string StreetNumberSuffix { get; set; }
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

        public virtual Country Country { get; set; }
        public virtual ICollection<Location2Business> Location2Businesses { get; set; }
        public virtual ICollection<Location2Person> Location2People { get; set; }
    }
}
