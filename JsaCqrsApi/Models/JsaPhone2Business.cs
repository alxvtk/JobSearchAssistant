using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaPhone2Business : Entity
    {
        public int Ph2bPhoneId { get; set; }
        public int Ph2bBusinessId { get; set; }
        public string Ph2bActive { get; set; }

        public virtual JsaBusiness Ph2bBusiness { get; set; }
        public virtual JsaPhone Ph2bPhone { get; set; }
    }
}
