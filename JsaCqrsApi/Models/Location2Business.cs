using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Location2Business
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int LocationId { get; set; }
        public string Active { get; set; }

        public virtual Business Business { get; set; }
        public virtual Location Location { get; set; }
    }
}
