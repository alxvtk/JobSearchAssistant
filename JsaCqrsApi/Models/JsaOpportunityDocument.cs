using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaOpportunityDocument : Entity
    {
        public JsaOpportunityDocument()
        {
            JsaOpportunityActions = new HashSet<JsaOpportunityAction>();
        }

        public int? OdOpportunityId { get; set; }
        public int? OdDocument { get; set; }

        public virtual JsaOpportunity OdOpportunity { get; set; }
        public virtual ICollection<JsaOpportunityAction> JsaOpportunityActions { get; set; }
    }
}
