using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaPerson2Business : Entity
    {
        public int P2bPersonId { get; set; }
        public int P2bBusinessId { get; set; }
        public string P2bActive { get; set; }

        public virtual JsaBusiness P2bBusiness { get; set; }
        public virtual JsaPerson P2bPerson { get; set; }
    }
}
