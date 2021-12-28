using JsaCqrsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
       
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

//------------------------------------------------------------------------------------------------------------------
        public DbSet<Product> Products { get; set; }
//------------------------------------------------------------------------------------------------------------------
        public DbSet<SourceType> SourceTypes { get; set; }
        public DbSet<UrlLink> UrlLinks { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<DocFormat> DocFormats { get; set; }
        public DbSet<ResultCategory> ResultCategorys { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<OpportunityActionType> OpportunityActionTypes { get; set; }
        public DbSet<ResultStatus> ResultStatuses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<OpportunityDocument> OpportunityDocuments { get; set; }
        public DbSet<OpportunityWorkflow> OpportunityWorkflows { get; set; }
        public DbSet<OpportunityAction> OpportunityActions { get; set; }
        public DbSet<OpportunityWorkflowAction> OpportunityWorkflowActions { get; set; }
        public DbSet<OpportunityActionPerson> OpportunityActionPersons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Email2Person> Email2Persons { get; set; }
        public DbSet<Phone2Person> Phone2Persons { get; set; }
        public DbSet<Email2Business> Email2Businesses { get; set; }
        public DbSet<UrlLink2Business> UrlLink2Businesses { get; set; }
        public DbSet<Phone2Business> Phone2Businesses { get; set; }
        public DbSet<Person2Business> Person2Businesses { get; set; }
        public DbSet<Location2Person> Location2Persons { get; set; }
        public DbSet<Location2Business> Location2Businesses { get; set; }



        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


//------------------------------------------------------------------------------------------------------------------
            modelBuilder.Entity<Product>()
                .Property(p => p.BuyingPrice)
                .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Product>()
                .Property(p => p.Rate)
                .HasColumnType("decimal(18,4)");
//------------------------------------------------------------------------------------------------------------------


            // #01
            modelBuilder.Entity<SourceType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__st_Id");

                entity.ToTable("SourceType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Type");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TypeName");
            });

            // #02
            modelBuilder.Entity<UrlLink>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__u_Id");

                entity.ToTable("Url");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("Body");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Comment");
            });

            // -----------------------------------------------------------------
            // #03
            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__e_Id");

                entity.ToTable("Email");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("Address");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Comment");
            });

            // #04
            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ph_Id");

                entity.ToTable("Phone");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Comment");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fax")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("Name");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("Number");
            });

            // #05
            modelBuilder.Entity<DocFormat> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__df_Id");

                entity.ToTable("DocFormat");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Type");

            });

            // #06
            modelBuilder.Entity<ResultCategory> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__rc_Id");

                entity.ToTable("ResultCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Name");

            });

            // #07
            modelBuilder.Entity<Country> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__c_Id");

                entity.ToTable("Country");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("Name");
            });

            // #08
            modelBuilder.Entity<OpportunityActionType> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__oat_Id");

                entity.ToTable("OpportunityActionType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Description");

                entity.Property(e => e.Note)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Note");

                entity.Property(e => e.SequenceNumber).HasColumnName("SequenceNumber");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("Title");
            });
            
            // #09
            modelBuilder.Entity<ResultStatus> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__rs_Id");

                entity.ToTable("ResultStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ResultStatuses)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rs_CategoryId_2_rc_Id");
            });

            // #10
            modelBuilder.Entity<Location> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__l_Id");

                entity.ToTable("Location");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Comments");

                entity.Property(e => e.CountryId).HasColumnName("CountryId");

                entity.Property(e => e.Municipality)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Municipality");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PostalCode");

                entity.Property(e => e.Province)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Province");

                entity.Property(e => e.StreetDirection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StreetDirection");

                entity.Property(e => e.StreetLine1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("StreetLine1");

                entity.Property(e => e.StreetLine2)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("StreetLine2");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("StreetName");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StreetNumber");

                entity.Property(e => e.StreetNumberSuffix)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StreetNumberSuffix");

                entity.Property(e => e.StreetType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StreetType");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Unit");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LocationList)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l_CountryId_2_c_Id");
            });

            // #11
            modelBuilder.Entity<Business> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__b_Id");

                entity.ToTable("Business");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Name");
            });

            // #12
            modelBuilder.Entity<Person> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__p_Id");

                entity.ToTable("Person");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1028)
                    .IsUnicode(false)
                    .HasColumnName("Comments");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("FirstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("LastName");

                entity.Property(e => e.NickName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("NickName");

                entity.Property(e => e.Position)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("Position");

                entity.Property(e => e.Title)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("Title");
            });

            // #13
            modelBuilder.Entity<Source> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__s_Id");

                entity.ToTable("Source");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.SourceTypeId).HasColumnName("SourceTypeId");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.Property(e => e.UrlId).HasColumnName("UrlId");

                entity.Property(e => e.EmailId).HasColumnName("EmailId");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("Comment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Name");


                entity.HasOne(d => d.Email)
                    .WithMany(p => p.SourceList)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_s_EmailId_2_e_Id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Sources)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__s_PersonId_2_p_Id");

                entity.HasOne(d => d.SourceType)
                    .WithMany(p => p.Sources)
                    .HasForeignKey(d => d.SourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__s_SourceTypeId_2_st_Id");

                entity.HasOne(d => d.UrlLink)
                    .WithMany(p => p.Sources)
                    .HasForeignKey(d => d.UrlId)
                    .HasConstraintName("FK__s_UrlId_2_u_Id");
            });

            // #14
            modelBuilder.Entity<Document> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__d_Id");

                entity.ToTable("Document");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Body");

                entity.Property(e => e.DocFormatId).HasColumnName("DocFormatId");

                entity.Property(e => e.EmailId).HasColumnName("EmailId");

                entity.Property(e => e.FullPath)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("FullPath");

                entity.Property(e => e.UrLinklId).HasColumnName("UrlId");

                entity.HasOne(d => d.DocFormat)
                    .WithMany(p => p.DocumentList)
                    .HasForeignKey(d => d.DocFormatId)
                    .HasConstraintName("FK__d_DocFormatId_2_df_Id");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.DocumentList)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK__d_EmailId_2_e_Id");

                entity.HasOne(d => d.UrlLink)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.UrLinklId)
                    .HasConstraintName("FK__d_UrlId_2_u_Id");

            });

            // #15
            modelBuilder.Entity<JobDescription> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__jd_Id");

                entity.ToTable("JobDescription");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentId");

                entity.Property(e => e.SourceId).HasColumnName("SourceId");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.JobDescriptions)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__jd_SourceId_2_s_Id");
            });

            // #16
            modelBuilder.Entity<Resume> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__r_Id");

                entity.ToTable("Resume");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");
            });

            // #17
            modelBuilder.Entity<Opportunity> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__o_Id");

                entity.ToTable("Opportunity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active")
                    .IsFixedLength(true);

                entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionId");

                entity.Property(e => e.ResumeId).HasColumnName("ResumeId");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__o_JobDescriptionId_2_jd_Id");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.ResumeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__o_ResumeId_2_r_Id");
            });

            // #18
            modelBuilder.Entity<OpportunityDocument> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__od_Id");

                entity.ToTable("OpportunityDocument");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Document).HasColumnName("Document");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityId");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.OpportunityDocuments)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK__od_OpportunityId_2_o_Id");
            });

            // #19
            modelBuilder.Entity<OpportunityWorkflow> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ow_Id");

                entity.ToTable("OpportunityWorkflow");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DateTime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Description");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityId");

                entity.Property(e => e.WorkFlowResultStatusId).HasColumnName("WorkFlowResultStatusId");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.OpportunityWorkflows)
                    .HasForeignKey(d => d.OpportunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ow_OpportunityId_2_o_Id");

                entity.HasOne(d => d.WorkFlowResultStatus)
                    .WithMany(p => p.OpportunityWorkflows)
                    .HasForeignKey(d => d.WorkFlowResultStatusId)
                    .HasConstraintName("FK_ow_WorkflowResultStatusId_2_rs_Id");
            });

            // #20
            modelBuilder.Entity<OpportunityAction> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__oa_Id");

                entity.ToTable("OpportunityAction");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.ActionResultStatusId).HasColumnName("ActionResultStatusId");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DateTime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Description");

                entity.Property(e => e.OpportunityActionTypeId).HasColumnName("OpportunityActionTypeId");

                entity.Property(e => e.OpportunityDocumentId).HasColumnName("OpportunityDocumentId");

                entity.HasOne(d => d.ActionResultStatus)
                    .WithMany(p => p.OpportunityActions)
                    .HasForeignKey(d => d.ActionResultStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oa_ResultStatusId_2_rs_Id");

                entity.HasOne(d => d.OpportunityActionType)
                    .WithMany(p => p.OpportunityActions)
                    .HasForeignKey(d => d.OpportunityActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oa_OpportunityActionTypeId_2_oat_Id");

                entity.HasOne(d => d.OpportunityDocument)
                    .WithMany(p => p.OpportunityActions)
                    .HasForeignKey(d => d.OpportunityDocumentId)
                    .HasConstraintName("FK__oa_OpportunityDocumentId_2_od_Id");
            });

            // #21
            modelBuilder.Entity<OpportunityWorkflowAction> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__owa_Id");

                entity.ToTable("OpportunityWorkflowAction");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.OpportunityActionId).HasColumnName("OpportunityActionId");

                entity.Property(e => e.OpportunityWorkflowId).HasColumnName("OpportunityWorkflowId");

                entity.HasOne(d => d.OpportunityAction)
                    .WithMany(p => p.OpportunityWorkflowActions)
                    .HasForeignKey(d => d.OpportunityActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__owa_OpportunityActionId_2_oa_Id");

                entity.HasOne(d => d.OpportunityWorkflow)
                    .WithMany(p => p.OpportunityWorkflowActions)
                    .HasForeignKey(d => d.OpportunityWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__owa_OpportunityWorkflowId_2_ow_Id");
            });

            // #22
            modelBuilder.Entity<OpportunityActionPerson> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__oap_Id");

                entity.ToTable("OpportunityActionPeople");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.OpportunityActionId).HasColumnName("OpportunityActionId");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.HasOne(d => d.OpportunityAction)
                    .WithMany(p => p.OpportunityActionPeople)
                    .HasForeignKey(d => d.OpportunityActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oap_OpportunityActionId_2_oa_Id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.OpportunityActionPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oap_PersonId_2_p_Id");
            });

            // #23
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__usr_Id");

                entity.ToTable("User");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__usr_PersonId_2_p_Id");
            });

            // #24
            modelBuilder.Entity<Email2Person> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__e2p_Id");

                entity.ToTable("Email2Person");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.EmailId).HasColumnName("EmailId");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Email2PeopleList)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__e2p_EmailId_2_e_Id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Email2Person)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__e2p_PersonId_2_p_Id");
            });

            // #25
            modelBuilder.Entity<Phone2Person> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ph2p_Id");

                entity.ToTable("jsa_Phone2Person");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Phone2Person)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2p_PersonId_2_p_Id");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.Phone2People)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2p_PhoneId_2_ph_Id");

            });

            // #26
            modelBuilder.Entity<Email2Business> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__e2b_Id");

                entity.ToTable("Email2Business");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessId");

                entity.Property(e => e.EmailId).HasColumnName("EmailId");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Email2BusinessList)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_e2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Email2BusinessList)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_e2b_EmailId_2_e_Id");
            });

            // #27
            modelBuilder.Entity<UrlLink2Business> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__u2b_Id");

                entity.ToTable("UrlLink2Business");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessId");

                entity.Property(e => e.UrlId).HasColumnName("UrlId");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.UrlLink2BusinessList)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_u2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.UrlLink)
                    .WithMany(p => p.UrlLink2Businesses)
                    .HasForeignKey(d => d.UrlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_u2b_UrlId_2_u_Id");

            });

            // #28
            modelBuilder.Entity<Phone2Business> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ph2b_Id");

                entity.ToTable("Phone2Business");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessId");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneId");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Phone2BusinessList)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.Phone2Businesses)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2b_PhoneId_2_ph_Id");

            });

            // #29
            modelBuilder.Entity<Person2Business> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__p2b_Id");

                entity.ToTable("Person2Business");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessId");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Person2BusinessList)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__p2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Person2Businesses)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__p2b_PersonId_2_p_Id");
            });

            // #30
            modelBuilder.Entity<Location2Person> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__l2p_Id");

                entity.ToTable("Location2Person");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.Property(e => e.LocationId).HasColumnName("LocationId");

                entity.Property(e => e.PersonId).HasColumnName("PersonId");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Location2People)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2p_LocationId_2_l_Id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Location2Person)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2p_PersonId_2_p_Id");
            });

            // #31
            modelBuilder.Entity<Location2Business> (entity => 
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__l2b_Id");

                entity.ToTable("Location2Business");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessId");

                entity.Property(e => e.LocationId).HasColumnName("LocationId");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Active");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Location2BusinessList)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Location2Businesses)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2b_LocationId_2_l_Id");
            });








            /*
                    DbSet<Email> Emails(entity => {});
                    DbSet<Phone> Phones(entity => {});
                    DbSet<DocFormat> DocFormats(entity => {});
                    DbSet<ResultCategory> ResultCategorys(entity => {});
                    DbSet<Country> Countries(entity => {});
                    DbSet<OpportunityActionType> OpportunityActionTypes(entity => {});
                    DbSet<ResultStatus> ResultStatuses(entity => {});
                    DbSet<Location> Locations(entity => {});
                    DbSet<Business> Businesses(entity => {});
                    DbSet<Person> Persons(entity => {});
                    DbSet<Source> Sources(entity => {});
                    DbSet<Document> Documents(entity => {});
                    DbSet<JobDescription> JobDescriptions(entity => {});
                    DbSet<Resume> Resumes(entity => {});
                    DbSet<Opportunity> Opportunities(entity => {});
                    DbSet<OpportunityDocument> OpportunityDocuments(entity => {});
                    DbSet<OpportunityWorkflow> OpportunityWorkflows(entity => {});
                    DbSet<OpportunityAction> OpportunityActions(entity => {});
                    DbSet<OpportunityWorkflowAction> OpportunityWorkflowActions(entity => {});
                    DbSet<OpportunityActionPerson> OpportunityActionPersons(entity => {});
                    DbSet<Email2Person> Email2Persons(entity => {});
                    DbSet<Phone2Person> Phone2Persons(entity => {});
                    DbSet<Email2Business> Email2Businesses(entity => {});
                    DbSet<UrlLink2Business> UrlLink2Businesses(entity => {});
                    DbSet<Phone2Business> Phone2Businesses(entity => {});
                    DbSet<Person2Business> Person2Businesses(entity => {});
                    DbSet<Location2Person> Location2Persons(entity => {});
                    DbSet<Location2Business> Location2Businesses(entity => {});


            */

        }
    }
}
