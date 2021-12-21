using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaResultCategory
    {
        public JsaResultCategory()
        {
            JsaResultStatuses = new HashSet<JsaResultStatus>();
        }

        public int RcId { get; set; }
        public string RcName { get; set; }
        public string RcCode { get; set; }

        public virtual ICollection<JsaResultStatus> JsaResultStatuses { get; set; }
    }
}
