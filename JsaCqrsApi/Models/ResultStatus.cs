using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class ResultStatus
    {
        public ResultStatus()
        {
            OpportunityActions = new HashSet<OpportunityAction>();
            OpportunityWorkflows = new HashSet<OpportunityWorkflow>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }

        public virtual ResultCategory Category { get; set; }
        public virtual ICollection<OpportunityAction> OpportunityActions { get; set; }
        public virtual ICollection<OpportunityWorkflow> OpportunityWorkflows { get; set; }
    }
}
