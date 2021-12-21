using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaOpportunityDocument
    {
        public JsaOpportunityDocument()
        {
            JsaOpportunityActions = new HashSet<JsaOpportunityAction>();
        }

        public int OdId { get; set; }
        public int? OdOpportunityId { get; set; }
        public int? OdDocument { get; set; }

        public virtual JsaOpportunity OdOpportunity { get; set; }
        public virtual ICollection<JsaOpportunityAction> JsaOpportunityActions { get; set; }
    }
}
