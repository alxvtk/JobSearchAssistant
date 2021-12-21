using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaDocument
    {
        public int DId { get; set; }
        public int? DUrlId { get; set; }
        public int? DEmailId { get; set; }
        public int? DDocFormatId { get; set; }
        public string DBody { get; set; }
        public string DFullPath { get; set; }

        public virtual JsaDocFormat DDocFormat { get; set; }
        public virtual JsaEmail DEmail { get; set; }
        public virtual JsaUrl DUrl { get; set; }
    }
}
