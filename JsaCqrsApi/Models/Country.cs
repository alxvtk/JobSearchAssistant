using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Country
    {
        public Country()
        {
            LocationList = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Location> LocationList { get; set; }
    }
}
