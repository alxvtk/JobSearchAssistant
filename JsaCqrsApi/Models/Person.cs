using System;
using System.Collections.Generic;

#nullable disable

namespace JsaApi.Models
{
    public partial class JsaPerson
    {
        public JsaPerson()
        {
            JsaEmail2People = new HashSet<JsaEmail2Person>();
            JsaLocation2People = new HashSet<JsaLocation2Person>();
            JsaOpportunityActionPeople = new HashSet<JsaOpportunityActionPerson>();
            JsaPerson2Businesses = new HashSet<JsaPerson2Business>();
            JsaPhone2People = new HashSet<JsaPhone2Person>();
            JsaSources = new HashSet<JsaSource>();
            JsaUsers = new HashSet<JsaUser>();
        }

        public int PId { get; set; }
        public string PTitle { get; set; }
        public string PFirstName { get; set; }
        public string PLastName { get; set; }
        public string PNickName { get; set; }
        public string PPosition { get; set; }
        public string PComments { get; set; }

        public virtual ICollection<JsaEmail2Person> JsaEmail2People { get; set; }
        public virtual ICollection<JsaLocation2Person> JsaLocation2People { get; set; }
        public virtual ICollection<JsaOpportunityActionPerson> JsaOpportunityActionPeople { get; set; }
        public virtual ICollection<JsaPerson2Business> JsaPerson2Businesses { get; set; }
        public virtual ICollection<JsaPhone2Person> JsaPhone2People { get; set; }
        public virtual ICollection<JsaSource> JsaSources { get; set; }
        public virtual ICollection<JsaUser> JsaUsers { get; set; }
    }
}
