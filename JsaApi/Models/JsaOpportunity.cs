using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaOpportunity
    {
        public JsaOpportunity()
        {
            JsaOpportunityDocuments = new HashSet<JsaOpportunityDocument>();
            JsaOpportunityWorkflows = new HashSet<JsaOpportunityWorkflow>();
        }

        public int OId { get; set; }
        public int OJobDescriptionId { get; set; }
        public int OResumeId { get; set; }
        public string OActive { get; set; }

        public virtual JsaJobDescription OJobDescription { get; set; }
        public virtual JsaResume OResume { get; set; }
        public virtual ICollection<JsaOpportunityDocument> JsaOpportunityDocuments { get; set; }
        public virtual ICollection<JsaOpportunityWorkflow> JsaOpportunityWorkflows { get; set; }
    }
}
