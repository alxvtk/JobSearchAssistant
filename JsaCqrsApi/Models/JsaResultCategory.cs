using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaResultCategory : Entity
    {
        public JsaResultCategory()
        {
            JsaResultStatuses = new HashSet<JsaResultStatus>();
        }

        public string RcName { get; set; }
        public string RcCode { get; set; }

        public virtual ICollection<JsaResultStatus> JsaResultStatuses { get; set; }
    }
}
