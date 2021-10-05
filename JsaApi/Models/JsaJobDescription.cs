using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaJobDescription
    {
        public JsaJobDescription()
        {
            JsaOpportunities = new HashSet<JsaOpportunity>();
        }

        public int JdId { get; set; }
        public int JdSourceId { get; set; }
        public int JdDocumentId { get; set; }

        public virtual JsaSource JdSource { get; set; }
        public virtual ICollection<JsaOpportunity> JsaOpportunities { get; set; }
    }
}
