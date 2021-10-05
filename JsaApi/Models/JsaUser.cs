using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaUser
    {
        public int UsrId { get; set; }
        public int UsrPersonId { get; set; }

        public virtual JsaPerson UsrPerson { get; set; }
    }
}
