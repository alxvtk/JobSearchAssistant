using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaUrl2Business
    {
        public int U2bId { get; set; }
        public int U2bUrlId { get; set; }
        public int U2bBusinessId { get; set; }
        public string U2bActive { get; set; }

        public virtual JsaBusiness U2bBusiness { get; set; }
        public virtual JsaUrl U2bUrl { get; set; }
    }
}
