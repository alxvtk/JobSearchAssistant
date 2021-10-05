using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaEmail2Person
    {
        public int E2pId { get; set; }
        public int E2pEmailId { get; set; }
        public int E2pPersonId { get; set; }
        public string E2pActive { get; set; }

        public virtual JsaEmail E2pEmail { get; set; }
        public virtual JsaPerson E2pPerson { get; set; }
    }
}
