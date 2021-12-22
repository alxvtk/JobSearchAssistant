using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Opportunity
    {
        public Opportunity()
        {
            OpportunityDocuments = new HashSet<OpportunityDocument>();
            OpportunityWorkflows = new HashSet<OpportunityWorkflow>();
        }

        public int Id { get; set; }
        public int JobDescriptionId { get; set; }
        public int ResumeId { get; set; }
        public string Active { get; set; }

        public virtual JobDescription JobDescription { get; set; }
        public virtual Resume Resume { get; set; }
        public virtual ICollection<OpportunityDocument> OpportunityDocuments { get; set; }
        public virtual ICollection<OpportunityWorkflow> OpportunityWorkflows { get; set; }
    }
}
