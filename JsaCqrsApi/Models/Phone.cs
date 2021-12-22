using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Phone
    {
        public Phone()
        {
            Phone2Businesses = new HashSet<Phone2Business>();
            Phone2People = new HashSet<Phone2Person>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Fax { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Phone2Business> Phone2Businesses { get; set; }
        public virtual ICollection<Phone2Person> Phone2People { get; set; }
    }
}
