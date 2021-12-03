using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaOpportunityAction : Entity
    {
        public JsaOpportunityAction()
        {
            JsaOpportunityActionPeople = new HashSet<JsaOpportunityActionPerson>();
            JsaOpportunityWorkflowActions = new HashSet<JsaOpportunityWorkflowAction>();
        }

        public int OaOpportunityActionTypeId { get; set; }
        public int OaActionResultStatusId { get; set; }
        public int? OaOpportunityDocumentId { get; set; }
        public DateTime? OaDateTime { get; set; }
        public string OaDescription { get; set; }

        public virtual JsaResultStatus OaActionResultStatus { get; set; }
        public virtual JsaOpportunityActionType OaOpportunityActionType { get; set; }
        public virtual JsaOpportunityDocument OaOpportunityDocument { get; set; }
        public virtual ICollection<JsaOpportunityActionPerson> JsaOpportunityActionPeople { get; set; }
        public virtual ICollection<JsaOpportunityWorkflowAction> JsaOpportunityWorkflowActions { get; set; }
    }
}
