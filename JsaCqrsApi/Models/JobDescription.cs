using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class JobDescription
    {
        public JobDescription()
        {
            Opportunities = new HashSet<Opportunity>();
        }

        public int Id { get; set; }
        public int SourceId { get; set; }
        public int DocumentId { get; set; }

        public virtual Source Source { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
