using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class OpportunityAction
    {
        public OpportunityAction()
        {
            OpportunityActionPeople = new HashSet<OpportunityActionPerson>();
            OpportunityWorkflowActions = new HashSet<OpportunityWorkflowAction>();
        }

        public int Id { get; set; }
        public int OpportunityActionTypeId { get; set; }
        public int ActionResultStatusId { get; set; }
        public int? OpportunityDocumentId { get; set; }
        public DateTime? DateTime { get; set; }
        public string Description { get; set; }

        public virtual ResultStatus ActionResultStatus { get; set; }
        public virtual OpportunityActionType OpportunityActionType { get; set; }
        public virtual OpportunityDocument OpportunityDocument { get; set; }
        public virtual ICollection<OpportunityActionPerson> OpportunityActionPeople { get; set; }
        public virtual ICollection<OpportunityWorkflowAction> OpportunityWorkflowActions { get; set; }
    }
}
