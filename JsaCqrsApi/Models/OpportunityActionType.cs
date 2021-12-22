using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaOpportunityActionType
    {
        public JsaOpportunityActionType()
        {
            JsaOpportunityActions = new HashSet<JsaOpportunityAction>();
        }

        public int OatId { get; set; }
        public int OatSequenceNumber { get; set; }
        public string OatTitle { get; set; }
        public string OatDescription { get; set; }
        public string OatNote { get; set; }

        public virtual ICollection<JsaOpportunityAction> JsaOpportunityActions { get; set; }
    }
}
