using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchAssistantAPI.Data
{
    [Table("Country")]
    public partial class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        //public virtual IList<Location> Locations { get; set; }
    }
}