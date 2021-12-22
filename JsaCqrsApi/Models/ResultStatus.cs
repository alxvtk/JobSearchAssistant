using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaResultStatus
    {
        public JsaResultStatus()
        {
            JsaOpportunityActions = new HashSet<JsaOpportunityAction>();
            JsaOpportunityWorkflows = new HashSet<JsaOpportunityWorkflow>();
        }

        public int RsId { get; set; }
        public string RsName { get; set; }
        public string RsCode { get; set; }
        public int RsCategoryId { get; set; }

        public virtual JsaResultCategory RsCategory { get; set; }
        public virtual ICollection<JsaOpportunityAction> JsaOpportunityActions { get; set; }
        public virtual ICollection<JsaOpportunityWorkflow> JsaOpportunityWorkflows { get; set; }
    }
}
