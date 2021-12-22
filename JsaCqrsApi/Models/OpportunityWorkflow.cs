using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class OpportunityWorkflow
    {
        public OpportunityWorkflow()
        {
            OpportunityWorkflowActions = new HashSet<OpportunityWorkflowAction>();
        }

        public int Id { get; set; }
        public int OpportunityId { get; set; }
        public int? WorkFlowResultStatusId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Description { get; set; }

        public virtual Opportunity Opportunity { get; set; }
        public virtual ResultStatus WorkFlowResultStatus { get; set; }
        public virtual ICollection<OpportunityWorkflowAction> OpportunityWorkflowActions { get; set; }
    }
}
