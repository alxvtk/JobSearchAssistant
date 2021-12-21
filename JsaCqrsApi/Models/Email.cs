using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaEmail
    {
        public JsaEmail()
        {
            JsaDocuments = new HashSet<JsaDocument>();
            JsaEmail2Businesses = new HashSet<JsaEmail2Business>();
            JsaEmail2People = new HashSet<JsaEmail2Person>();
            JsaSources = new HashSet<JsaSource>();
        }

        public int EId { get; set; }
        public string EAddress { get; set; }
        public string EComment { get; set; }

        public virtual ICollection<JsaDocument> JsaDocuments { get; set; }
        public virtual ICollection<JsaEmail2Business> JsaEmail2Businesses { get; set; }
        public virtual ICollection<JsaEmail2Person> JsaEmail2People { get; set; }
        public virtual ICollection<JsaSource> JsaSources { get; set; }
    }
}
