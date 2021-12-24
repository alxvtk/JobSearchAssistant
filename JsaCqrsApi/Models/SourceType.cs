using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Domain.Models
{
    public class SourceType
    {

        public SourceType()
        {
            Sources = new HashSet<Source>();
        }


        public int Id { get; set; }
        public string Type { get; set; }
        public string TypeName { get; set; }


        public virtual ICollection<Source> Sources { get; set; }

    }
}
