using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaOpportunityActionType : Entity
    {
        public JsaOpportunityActionType()
        {
            JsaOpportunityActions = new HashSet<JsaOpportunityAction>();
        }

        public int OatSequenceNumber { get; set; }
        public string OatTitle { get; set; }
        public string OatDescription { get; set; }
        public string OatNote { get; set; }

        public virtual ICollection<JsaOpportunityAction> JsaOpportunityActions { get; set; }
    }
}
