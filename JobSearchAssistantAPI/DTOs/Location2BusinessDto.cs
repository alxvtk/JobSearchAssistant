using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.DTOs
{
    public class Location2BusinessDto
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int LocationId { get; set; }
        public bool Active { get; set; }
    }
}
