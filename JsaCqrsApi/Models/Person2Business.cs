using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Person2Business
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int BusinessId { get; set; }
        public string Active { get; set; }

        public virtual Business Business { get; set; }
        public virtual Person Person { get; set; }
    }
}
