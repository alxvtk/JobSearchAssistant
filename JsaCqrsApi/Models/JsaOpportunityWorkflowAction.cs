using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaOpportunityWorkflowAction : Entity
    {
        public int OwaOpportunityWorkflowId { get; set; }
        public int OwaOpportunityActionId { get; set; }

        public virtual JsaOpportunityAction OwaOpportunityAction { get; set; }
        public virtual JsaOpportunityWorkflow OwaOpportunityWorkflow { get; set; }
    }
}
