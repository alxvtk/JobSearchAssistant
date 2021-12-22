using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class OpportunityActionType
    {
        public OpportunityActionType()
        {
            OpportunityActions = new HashSet<OpportunityAction>();
        }

        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public virtual ICollection<OpportunityAction> OpportunityActions { get; set; }
    }
}
