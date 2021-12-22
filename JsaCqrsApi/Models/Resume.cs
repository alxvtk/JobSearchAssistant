using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Resume
    {
        public Resume()
        {
            Opportunities = new HashSet<Opportunity>();
        }

        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int Version { get; set; }
        public int? SubVersion { get; set; }
        public DateTime VersioningDate { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
