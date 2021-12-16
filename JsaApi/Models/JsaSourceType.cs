using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaSourceType
    {
        public JsaSourceType()
        {
            JsaSources = new HashSet<JsaSource>();
        }

        public int StId { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }
    
        public virtual ICollection<JsaSource> JsaSources { get; set; }
    }
}
