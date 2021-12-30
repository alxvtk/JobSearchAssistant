using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class Person
    {
        public Person()
        {
            Email2Person = new HashSet<Email2Person>();
            Location2Person = new HashSet<Location2Person>();
            OpportunityActionPerson = new HashSet<OpportunityActionPerson>();
            Person2Businesses = new HashSet<Person2Business>();
            Phone2Person = new HashSet<Phone2Person>();
            Sources = new HashSet<Source>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Email2Person> Email2Person { get; set; }
        public virtual ICollection<Location2Person> Location2Person { get; set; }
        public virtual ICollection<OpportunityActionPerson> OpportunityActionPerson { get; set; }
        public virtual ICollection<Person2Business> Person2Businesses { get; set; }
        public virtual ICollection<Phone2Person> Phone2Person { get; set; }
        public virtual ICollection<Source> Sources { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
