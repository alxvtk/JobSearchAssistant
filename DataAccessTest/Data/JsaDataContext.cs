using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessTest.Data
{
    public class JsaDataContext : DbContext
    {
        public JsaDataContext(DbContextOptions<JsaDataContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Location>().ToTable("Location");
        }
    }
}
