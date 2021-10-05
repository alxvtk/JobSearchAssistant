using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaPhone2Person
    {
        public int Ph2pId { get; set; }
        public int Ph2pPhoneId { get; set; }
        public int Ph2pPersonId { get; set; }
        public string Ph2pActive { get; set; }

        public virtual JsaPerson Ph2pPerson { get; set; }
        public virtual JsaPhone Ph2pPhone { get; set; }
    }
}
