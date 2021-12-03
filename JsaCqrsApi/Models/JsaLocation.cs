using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Models
{
    public partial class JsaLocation : Entity
    {
        public JsaLocation()
        {
            JsaLocation2Businesses = new HashSet<JsaLocation2Business>();
            JsaLocation2People = new HashSet<JsaLocation2Person>();
        }

        public string LStreetNumber { get; set; }
        public string LStreetNumberSuffix { get; set; }
        public string LStreetName { get; set; }
        public string LStreetType { get; set; }
        public string LStreetDirection { get; set; }
        public string LUnit { get; set; }
        public string LMunicipality { get; set; }
        public string LProvince { get; set; }
        public int LCountryId { get; set; }
        public string LPostalCode { get; set; }
        public string LStreetLine1 { get; set; }
        public string LStreetLine2 { get; set; }
        public string LComments { get; set; }

        public virtual JsaCountry LCountry { get; set; }
        public virtual ICollection<JsaLocation2Business> JsaLocation2Businesses { get; set; }
        public virtual ICollection<JsaLocation2Person> JsaLocation2People { get; set; }
    }
}
