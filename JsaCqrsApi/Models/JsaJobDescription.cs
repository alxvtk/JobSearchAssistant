using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaJobDescription : Entity
    {
        public JsaJobDescription()
        {
            JsaOpportunities = new HashSet<JsaOpportunity>();
        }

        public int JdSourceId { get; set; }
        public int JdDocumentId { get; set; }

        public virtual JsaSource JdSource { get; set; }
        public virtual ICollection<JsaOpportunity> JsaOpportunities { get; set; }
    }
}
