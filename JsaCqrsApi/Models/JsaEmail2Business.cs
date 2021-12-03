using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaEmail2Business : Entity
    {
        public int E2bEmailId { get; set; }
        public int E2bBusinessId { get; set; }
        public string E2bActive { get; set; }

        public virtual JsaBusiness E2bBusiness { get; set; }
        public virtual JsaEmail E2bEmail { get; set; }
    }
}
