using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Email
    {
        public Email()
        {
            DocumentList = new HashSet<Document>();
            Email2BusinessList = new HashSet<Email2Business>();
            Email2PeopleList = new HashSet<Email2Person>();
            SourceList = new HashSet<Source>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Document> DocumentList { get; set; }
        public virtual ICollection<Email2Business> Email2BusinessList { get; set; }
        public virtual ICollection<Email2Person> Email2PeopleList { get; set; }
        public virtual ICollection<Source> SourceList { get; set; }
    }
}
