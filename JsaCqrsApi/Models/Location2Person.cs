using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Location2Person
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int LocationId { get; set; }
        public string Active { get; set; }

        public virtual Location Location { get; set; }
        public virtual Person Person { get; set; }
    }
}
