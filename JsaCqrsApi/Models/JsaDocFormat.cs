using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaDocFormat : Entity
    {
        public JsaDocFormat()
        {
            JsaDocuments = new HashSet<JsaDocument>();
        }

        public string DfType { get; set; }

        public virtual ICollection<JsaDocument> JsaDocuments { get; set; }
    }
}
