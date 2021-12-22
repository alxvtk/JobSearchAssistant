using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class User
    {
        public int UsrId { get; set; }
        public int UsrPersonId { get; set; }

        public virtual Person UsrPerson { get; set; }
    }
}
