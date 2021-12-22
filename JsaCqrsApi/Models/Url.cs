using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaUrl
    {
//        public JsaUrl()
//        {
//            JsaDocuments = new HashSet<JsaDocument>();
//            JsaSources = new HashSet<JsaSource>();
//            JsaUrl2Businesses = new HashSet<JsaUrl2Business>();
//        }

        public int Id { get; set; }
        public string jsaBody { get; set; }
        public string Comment { get; set; }

//        public virtual ICollection<JsaDocument> JsaDocuments { get; set; }
//        public virtual ICollection<JsaSource> JsaSources { get; set; }
//        public virtual ICollection<JsaUrl2Business> JsaUrl2Businesses { get; set; }
    }
}
