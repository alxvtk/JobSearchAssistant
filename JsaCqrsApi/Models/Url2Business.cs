using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Url2Business
    {
        public int Id { get; set; }
        public int UrlId { get; set; }
        public int BusinessId { get; set; }
        public string Active { get; set; }

        public virtual Business Business { get; set; }
        public virtual UrlLink UrlLink { get; set; }
    }
}
