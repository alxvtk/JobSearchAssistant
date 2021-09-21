using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchAssistantAPI.Data
{
    [Table("Business")]
    public partial class Business
    {
        public int Id { get; set; }
        public string Name{ get; set; }
    }
}