using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Business
    {
        public Business()
        {
            Email2BusinessList = new HashSet<Email2Business>();
            Location2BusinessList = new HashSet<Location2Business>();
            Person2BusinessList = new HashSet<Person2Business>();
            Phone2BusinessList = new HashSet<Phone2Business>();
            UrlLink2BusinessList = new HashSet<Url2Business>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Email2Business> Email2BusinessList { get; set; }
        public virtual ICollection<Location2Business> Location2BusinessList { get; set; }
        public virtual ICollection<Person2Business> Person2BusinessList { get; set; }
        public virtual ICollection<Phone2Business> Phone2BusinessList { get; set; }
        public virtual ICollection<Url2Business> UrlLink2BusinessList { get; set; }
    }
}
