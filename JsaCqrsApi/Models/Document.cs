using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Document
    {
        public int Id { get; set; }
        public int? UrlId { get; set; }
        public int? EmailId { get; set; }
        public int? DocFormatId { get; set; }
        public string Body { get; set; }
        public string FullPath { get; set; }

        public virtual DocFormat DocFormat { get; set; }
        public virtual Email Email { get; set; }
        public virtual UrlLink Url { get; set; }
    }
}
