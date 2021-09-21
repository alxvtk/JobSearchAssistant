using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchAssistantAPI.Data
{
    [Table("Location")]

    public partial class Location
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
        public int? CountryId { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Comments { get; set; }

    }
}