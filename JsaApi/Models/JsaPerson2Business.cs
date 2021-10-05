using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaPerson2Business
    {
        public int P2bId { get; set; }
        public int P2bPersonId { get; set; }
        public int P2bBusinessId { get; set; }
        public string P2bActive { get; set; }

        public virtual JsaBusiness P2bBusiness { get; set; }
        public virtual JsaPerson P2bPerson { get; set; }
    }
}
