using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Domain.Models
{
    public class JsaSourceType
    {
//        public JsaSourceType()
//        {
//            JsaSources = new HashSet<JsaSource>();
//        }

        public int StId { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

//        public virtual ICollection<JsaSource> JsaSources { get; set; }
    }
}
