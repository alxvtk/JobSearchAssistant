using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaSource
    {
//        public JsaSource()
//        {
//            JsaJobDescriptions = new HashSet<JsaJobDescription>();
//        }

        public int SId { get; set; }
        public int SSourceTypeId { get; set; }
        public int? SPersonId { get; set; }
        public int? SUrlId { get; set; }
        public int? SEmailId { get; set; }
        public string SName { get; set; }
        public string SComment { get; set; }

//        public virtual JsaEmail SEmail { get; set; }
//        public virtual JsaPerson SPerson { get; set; }
//        public virtual JsaSourceType SSourceType { get; set; }
//        public virtual JsaUrl SUrl { get; set; }
//        public virtual ICollection<JsaJobDescription> JsaJobDescriptions { get; set; }
    }
}
