using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaDocFormat
    {
        public JsaDocFormat()
        {
            JsaDocuments = new HashSet<JsaDocument>();
        }

        public int DfId { get; set; }
        public string DfType { get; set; }

        public virtual ICollection<JsaDocument> JsaDocuments { get; set; }
    }
}
