using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaCountry : Entity
    {
        public JsaCountry()
        {
            JsaLocations = new HashSet<JsaLocation>();
        }

        public string CCode { get; set; }
        public string CName { get; set; }

        public virtual ICollection<JsaLocation> JsaLocations { get; set; }
    }
}
