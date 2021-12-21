using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaOpportunityWorkflow
    {
        public JsaOpportunityWorkflow()
        {
            JsaOpportunityWorkflowActions = new HashSet<JsaOpportunityWorkflowAction>();
        }

        public int OwId { get; set; }
        public int OwOpportunityId { get; set; }
        public int? OwWorkFlowResultStatusId { get; set; }
        public DateTime? OwDateTime { get; set; }
        public string OwDescription { get; set; }

        public virtual JsaOpportunity OwOpportunity { get; set; }
        public virtual JsaResultStatus OwWorkFlowResultStatus { get; set; }
        public virtual ICollection<JsaOpportunityWorkflowAction> JsaOpportunityWorkflowActions { get; set; }
    }
}
