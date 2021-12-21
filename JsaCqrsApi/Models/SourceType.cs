using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Domain.Models
{
    public class SourceType
    {
//        public SourceType()
//        {
//            Sources = new HashSet<Source>();
//        }

        public int StId { get; set; }
        public string StType { get; set; }
        public string StTypeName { get; set; }

//        public virtual ICollection<Source> Sources { get; set; }
    }
}
