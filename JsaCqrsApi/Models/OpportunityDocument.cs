using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class OpportunityDocument
    {
        public OpportunityDocument()
        {
            OpportunityActions = new HashSet<OpportunityAction>();
        }

        public int Id { get; set; }
        public int? OpportunityId { get; set; }
        public int? Document { get; set; }

        public virtual Opportunity OdOpportunity { get; set; }
        public virtual ICollection<OpportunityAction> OpportunityActions { get; set; }
    }
}
