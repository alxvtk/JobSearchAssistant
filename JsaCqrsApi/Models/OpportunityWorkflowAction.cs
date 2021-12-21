using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaOpportunityWorkflowAction
    {
        public int OwaId { get; set; }
        public int OwaOpportunityWorkflowId { get; set; }
        public int OwaOpportunityActionId { get; set; }

        public virtual JsaOpportunityAction OwaOpportunityAction { get; set; }
        public virtual JsaOpportunityWorkflow OwaOpportunityWorkflow { get; set; }
    }
}
