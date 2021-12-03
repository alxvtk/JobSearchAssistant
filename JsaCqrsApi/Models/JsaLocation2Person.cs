using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaLocation2Person : Entity
    {
        public int L2pPersonId { get; set; }
        public int L2pLocationId { get; set; }
        public string L2pActive { get; set; }

        public virtual JsaLocation L2pLocation { get; set; }
        public virtual JsaPerson L2pPerson { get; set; }
    }
}
