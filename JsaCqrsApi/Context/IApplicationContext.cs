using JsaCqrsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<SourceType> SourceTypes { get; set; }
        DbSet<UrlLink> UrlLinks { get; set; }
        DbSet<Email> Emails { get; set; }
        DbSet<Phone> Phones { get; set; }
        DbSet<DocFormat> DocFormats { get; set; }
        DbSet<ResultCategory> ResultCategorys { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<OpportunityActionType> OpportunityActionTypes { get; set; }
        DbSet<ResultStatus> ResultStatuses { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Business> Businesses { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Source> Sources { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<JobDescription> JobDescriptions { get; set; }
        DbSet<Resume> Resumes { get; set; }
        DbSet<Opportunity> Opportunities { get; set; }
        DbSet<OpportunityDocument> OpportunityDocuments { get; set; }
        DbSet<OpportunityWorkflow> OpportunityWorkflows { get; set; }
        DbSet<OpportunityAction> OpportunityActions { get; set; }
        DbSet<OpportunityWorkflowAction> OpportunityWorkflowActions { get; set; }
        DbSet<OpportunityActionPerson> OpportunityActionPersons { get; set; }
        DbSet<Email2Person> Email2Persons { get; set; }
        DbSet<Phone2Person> Phone2Persons { get; set; }
        DbSet<Email2Business> Email2Businesses { get; set; }
        DbSet<UrlLink2Business> UrlLink2Businesses { get; set; }
        DbSet<Phone2Business> Phone2Businesses { get; set; }
        DbSet<Person2Business> Person2Businesses { get; set; }
        DbSet<Location2Person> Location2Persons { get; set; }
        DbSet<Location2Business> Location2Businesses { get; set; }

        Task<int> SaveChangesAsync();
    }
}