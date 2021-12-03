using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaUser : Entity
    {
        public int UsrPersonId { get; set; }

        public virtual JsaPerson UsrPerson { get; set; }
    }
}
