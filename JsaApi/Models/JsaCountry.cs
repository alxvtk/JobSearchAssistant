using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaCountry
    {
        public JsaCountry()
        {
            JsaLocations = new HashSet<JsaLocation>();
        }

        public int CId { get; set; }
        public string CCode { get; set; }
        public string CName { get; set; }

        public virtual ICollection<JsaLocation> JsaLocations { get; set; }
    }
}
