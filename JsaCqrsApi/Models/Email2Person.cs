using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Email2Person
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public int PersonId { get; set; }
        public string Active { get; set; }

        public virtual Email Email { get; set; }
        public virtual Person Person { get; set; }
    }
}
