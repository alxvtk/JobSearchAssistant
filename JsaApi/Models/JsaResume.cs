using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaResume
    {
        public JsaResume()
        {
            JsaOpportunities = new HashSet<JsaOpportunity>();
        }

        public int RId { get; set; }
        public int RDocumentId { get; set; }
        public int RVersion { get; set; }
        public int? RSubVersion { get; set; }
        public DateTime RVersioningDate { get; set; }
        public string RActive { get; set; }

        public virtual ICollection<JsaOpportunity> JsaOpportunities { get; set; }
    }
}
