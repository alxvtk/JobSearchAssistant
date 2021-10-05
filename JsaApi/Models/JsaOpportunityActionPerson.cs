using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaOpportunityActionPerson
    {
        public int OapId { get; set; }
        public int OapOpportunityActionId { get; set; }
        public int OapPersonId { get; set; }

        public virtual JsaOpportunityAction OapOpportunityAction { get; set; }
        public virtual JsaPerson OapPerson { get; set; }
    }
}
