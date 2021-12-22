using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class ResultCategory
    {
        public ResultCategory()
        {
            ResultStatuses = new HashSet<ResultStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<ResultStatus> ResultStatuses { get; set; }
    }
}
