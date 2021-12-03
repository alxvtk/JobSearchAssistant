using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaLocation2Business : Entity
    {
        public int L2bBusinessId { get; set; }
        public int L2bLocationId { get; set; }
        public string L2pActive { get; set; }

        public virtual JsaBusiness L2bBusiness { get; set; }
        public virtual JsaLocation L2bLocation { get; set; }
    }
}
