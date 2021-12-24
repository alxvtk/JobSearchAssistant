using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class UrlLink
    {

        public UrlLink()
        {
            Documents = new HashSet<Document>();
            Sources = new HashSet<Source>();
            UrlLink2Businesses = new HashSet<UrlLink2Business>();
        }


        public int Id { get; set; }
        public string Body { get; set; }
        public string Comment { get; set; }


        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Source> Sources { get; set; }
        public virtual ICollection<UrlLink2Business> UrlLink2Businesses { get; set; }

    }
}
