using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaSource : Entity
    {
        public int SSourceTypeId { get; set; }
        public int? SPersonId { get; set; }
        public int? SUrlId { get; set; }
        public int? SEmailId { get; set; }
        public string SName { get; set; }
        public string SComment { get; set; }

    }
}
