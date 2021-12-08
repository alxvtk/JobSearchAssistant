using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaSourceType : Entity
    {
        public JsaSourceType()
        {
            JsaSources = new HashSet<JsaSource>();
        }

        //public int Id { get; set; }

        public string StType { get; set; }
        public string StTypeName { get; set; }

        public virtual ICollection<JsaSource> JsaSources { get; set; }
    }
}
