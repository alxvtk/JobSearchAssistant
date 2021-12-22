using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Phone2Person
    {
        public int Id { get; set; }
        public int PhoneId { get; set; }
        public int PersonId { get; set; }
        public string Active { get; set; }

        public virtual Person Person { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
