using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchAssistantAPI.Data
{
    [Table("Location2Business")]
    public class Location2Business
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int LocationId {get; set;}
        public bool Active { get; set; }
    }
}