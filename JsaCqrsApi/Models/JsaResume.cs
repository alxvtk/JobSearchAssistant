using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaResume : Entity
    {
        public JsaResume()
      {
            JsaOpportunities = new HashSet<JsaOpportunity>();
        }

        public int RDocumentId { get; set; }
        public int RVersion { get; set; }
        public int? RSubVersion { get; set; }
        public DateTime RVersioningDate { get; set; }
        public string RActive { get; set; }

        public virtual ICollection<JsaOpportunity> JsaOpportunities { get; set; }
    }
}
