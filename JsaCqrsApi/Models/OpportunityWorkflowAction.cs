using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class OpportunityWorkflowAction
    {
        public int Id { get; set; }
        public int OpportunityWorkflowId { get; set; }
        public int OpportunityActionId { get; set; }

        public virtual OpportunityAction OpportunityAction { get; set; }
        public virtual OpportunityWorkflow OpportunityWorkflow { get; set; }
    }
}
