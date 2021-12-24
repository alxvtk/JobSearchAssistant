using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Source
    {
        public Source()
        {
            JobDescriptions = new HashSet<JobDescription>();
        }

        public int Id { get; set; }
        public int SourceTypeId { get; set; }
        public int? PersonId { get; set; }
        public int? UrlId { get; set; }
        public int? EmailId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public virtual Email Email { get; set; }
        public virtual Person Person { get; set; }
        public virtual SourceType SourceType { get; set; }
        public virtual UrlLink Url { get; set; }
        public virtual ICollection<JobDescription> JobDescriptions { get; set; }
    }
}
