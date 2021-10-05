using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaUrl
    {
        public JsaUrl()
        {
            JsaDocuments = new HashSet<JsaDocument>();
            JsaSources = new HashSet<JsaSource>();
            JsaUrl2Businesses = new HashSet<JsaUrl2Business>();
        }

        public int UId { get; set; }
        public string UBody { get; set; }
        public string UComment { get; set; }

        public virtual ICollection<JsaDocument> JsaDocuments { get; set; }
        public virtual ICollection<JsaSource> JsaSources { get; set; }
        public virtual ICollection<JsaUrl2Business> JsaUrl2Businesses { get; set; }
    }
}
