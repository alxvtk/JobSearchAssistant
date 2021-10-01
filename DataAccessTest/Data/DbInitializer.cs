using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessTest.Data
{
    public static class DbInitializer
    {
        public static void Initialize(JsaDataContext context)
        {
            context.Database.EnsureCreated();

            //Look for any location
            if (context.Locations.Any())
            {
                return; // DB has been seeded
            }

            // Countries
            var countries = new Country[]
            {
                new Country { CountryCode = "CA", CountryName = "Canada" }
            };

            foreach (Country c in countries)
            {
                context.Countries.Add(c);
            }
            context.SaveChanges();

            // Locations
            var locations = new Location[]
            {
                new Location {StreetNumber ="5941", StreetNumberSuffix = "", StreetName = "Leeside", StreetType = "Cres", StreetDirection = "", Unit = "", Municipality = "Mississauga", Province = "ON", CountryId = 1, PostalCode = "L5M5L8", StreetLine1 = "", StreetLine2 = "", Comments = "" },
                new Location {StreetNumber ="6688", StreetNumberSuffix = "", StreetName = "Kitimat", StreetType = "Road", StreetDirection = "", Unit = "", Municipality = "Mississauga", Province = "ON", CountryId = 1, PostalCode = "L5N1P8", StreetLine1 = "6688 Kitimat Road Mississauga", StreetLine2 = "Ontario, Canada, L5N1P8", Comments = "" }
            };

            foreach(Location l in locations)
            {
                context.Locations.Add(l);
            }
            context.SaveChanges();


        }
    }
}
