using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaPhone : Entity
    {
        public JsaPhone()
        {
            JsaPhone2Businesses = new HashSet<JsaPhone2Business>();
            JsaPhone2People = new HashSet<JsaPhone2Person>();
        }

        public string PhNumber { get; set; }
        public string PhName { get; set; }
        public string PhFax { get; set; }
        public string PhComment { get; set; }

        public virtual ICollection<JsaPhone2Business> JsaPhone2Businesses { get; set; }
        public virtual ICollection<JsaPhone2Person> JsaPhone2People { get; set; }
    }
}
