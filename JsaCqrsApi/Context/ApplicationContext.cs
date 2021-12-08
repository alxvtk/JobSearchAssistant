using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsaCqrsApi.Models;

namespace JsaCqrsApi.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<JsaSourceType> JsaSourceType { get; set; }
        public DbSet<JsaUrl> JsaUrl { get; set; }
        public DbSet<JsaEmail> JsaEmail { get; set; }
        public DbSet<JsaPhone> JsaPhone { get; set; }
        public DbSet<JsaCountry> JsaCountry { get; set; }
        public DbSet<JsaOpportunityActionType> JsaOpportunityActionType { get; set; }
        public DbSet<JsaResultStatus> JsaResultStatus { get; set; }
        public DbSet<JsaLocation> JsaLocation { get; set; }
        public DbSet<JsaBusiness> JsaBusiness { get; set; }
        public DbSet<JsaPerson> JsaPerson { get; set; }
        public DbSet<JsaSource> JsaSource { get; set; }
        public DbSet<JsaDocument> JsaDocument { get; set; }
        public DbSet<JsaJobDescription> JsaJobDescription { get; set; }
        public DbSet<JsaResume> JsaResume { get; set; }
        public DbSet<JsaOpportunity> JsaOpportunity { get; set; }
        public DbSet<JsaOpportunityDocument> JsaOpportunityDocument { get; set; }
        public DbSet<JsaOpportunityWorkflow> JsaOpportunityWorkflow { get; set; }
        public DbSet<JsaOpportunityAction> JsaOpportunityAction { get; set; }
        public DbSet<JsaOpportunityWorkflowAction> JsaOpportunityWorkflowAction { get; set; }
        public DbSet<JsaOpportunityActionPerson> JsaOpportunityActionPerson { get; set; }
        public DbSet<JsaUser> JsaUser { get; set; }
        public DbSet<JsaEmail2Person> JsaEmail2Person { get; set; }
        public DbSet<JsaPhone2Person> JsaPhone2Person { get; set; }
        public DbSet<JsaEmail2Business> JsaEmail2Business { get; set; }
        public DbSet<JsaUrl2Business> JsaUrl2Business { get; set; }
        public DbSet<JsaPhone2Business> JsaPhone2Business { get; set; }
        public DbSet<JsaPerson2Business> JsaPerson2Business { get; set; }
        public DbSet<JsaLocation2Person> JsaLocation2Person { get; set; }
        public DbSet<JsaLocation2Business> JsaLocation2Business { get; set; }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public async Task<int> SaveChanges()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            return await base.SaveChangesAsync();
        }

    }
}
