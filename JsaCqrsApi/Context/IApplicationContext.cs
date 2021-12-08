using JsaCqrsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace JsaCqrsApi.Context
{
    public interface IApplicationContext
    {
        DbSet<JsaBusiness> JsaBusiness { get; set; }
        DbSet<JsaCountry> JsaCountry { get; set; }
        DbSet<JsaDocument> JsaDocument { get; set; }
        DbSet<JsaEmail> JsaEmail { get; set; }
        DbSet<JsaEmail2Business> JsaEmail2Business { get; set; }
        DbSet<JsaEmail2Person> JsaEmail2Person { get; set; }
        DbSet<JsaJobDescription> JsaJobDescription { get; set; }
        DbSet<JsaLocation> JsaLocation { get; set; }
        DbSet<JsaLocation2Business> JsaLocation2Business { get; set; }
        DbSet<JsaLocation2Person> JsaLocation2Person { get; set; }
        DbSet<JsaOpportunity> JsaOpportunity { get; set; }
        DbSet<JsaOpportunityAction> JsaOpportunityAction { get; set; }
        DbSet<JsaOpportunityActionPerson> JsaOpportunityActionPerson { get; set; }
        DbSet<JsaOpportunityActionType> JsaOpportunityActionType { get; set; }
        DbSet<JsaOpportunityDocument> JsaOpportunityDocument { get; set; }
        DbSet<JsaOpportunityWorkflow> JsaOpportunityWorkflow { get; set; }
        DbSet<JsaOpportunityWorkflowAction> JsaOpportunityWorkflowAction { get; set; }
        DbSet<JsaPerson> JsaPerson { get; set; }
        DbSet<JsaPerson2Business> JsaPerson2Business { get; set; }
        DbSet<JsaPhone> JsaPhone { get; set; }
        DbSet<JsaPhone2Business> JsaPhone2Business { get; set; }
        DbSet<JsaPhone2Person> JsaPhone2Person { get; set; }
        DbSet<JsaResultStatus> JsaResultStatus { get; set; }
        DbSet<JsaResume> JsaResume { get; set; }
        DbSet<JsaSource> JsaSource { get; set; }
        DbSet<JsaSourceType> JsaSourceType { get; set; }
        DbSet<JsaUrl> JsaUrl { get; set; }
        DbSet<JsaUrl2Business> JsaUrl2Business { get; set; }
        DbSet<JsaUser> JsaUser { get; set; }

        Task<int> SaveChanges();
    }
}