using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaBusiness
    {
        public JsaBusiness()
        {
            JsaEmail2Businesses = new HashSet<JsaEmail2Business>();
            JsaLocation2Businesses = new HashSet<JsaLocation2Business>();
            JsaPerson2Businesses = new HashSet<JsaPerson2Business>();
            JsaPhone2Businesses = new HashSet<JsaPhone2Business>();
            JsaUrl2Businesses = new HashSet<JsaUrl2Business>();
        }

        public int BId { get; set; }
        public string BName { get; set; }

        public virtual ICollection<JsaEmail2Business> JsaEmail2Businesses { get; set; }
        public virtual ICollection<JsaLocation2Business> JsaLocation2Businesses { get; set; }
        public virtual ICollection<JsaPerson2Business> JsaPerson2Businesses { get; set; }
        public virtual ICollection<JsaPhone2Business> JsaPhone2Businesses { get; set; }
        public virtual ICollection<JsaUrl2Business> JsaUrl2Businesses { get; set; }
    }
}
