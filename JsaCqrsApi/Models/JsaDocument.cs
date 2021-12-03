using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaDocument : Entity
    {
        public int? DUrlId { get; set; }
        public int? DEmailId { get; set; }
        public int? DDocFormatId { get; set; }
        public string DBody { get; set; }
        public string DFullPath { get; set; }

    }
}
