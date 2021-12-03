using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaOpportunityActionPerson : Entity
    {
        public int OapOpportunityActionId { get; set; }
        public int OapPersonId { get; set; }

        public virtual JsaOpportunityAction OapOpportunityAction { get; set; }
        public virtual JsaPerson OapPerson { get; set; }
    }
}
