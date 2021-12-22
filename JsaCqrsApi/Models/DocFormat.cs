using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class DocFormat
    {
        public DocFormat()
        {
            DocumentList = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Document> DocumentList { get; set; }
    }
}
