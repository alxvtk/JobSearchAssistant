using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

/*
 Working line:
 Scaffold-DbContext "Server=DESKTOP-BCO1FP1\MSSQLAV;Database=JobSearchAssistant;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
*/

#nullable disable

namespace JsaApi.Models
{
    public partial class JobSearchAssistantContext : DbContext
    {
        public JobSearchAssistantContext()
        {
        }

        public JobSearchAssistantContext(DbContextOptions<JobSearchAssistantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JsaBusiness> JsaBusinesses { get; set; }
        public virtual DbSet<JsaCountry> JsaCountries { get; set; }
        public virtual DbSet<JsaDocFormat> JsaDocFormats { get; set; }
        public virtual DbSet<JsaDocument> JsaDocuments { get; set; }
        public virtual DbSet<JsaEmail> JsaEmails { get; set; }
        public virtual DbSet<JsaEmail2Business> JsaEmail2Businesses { get; set; }
        public virtual DbSet<JsaEmail2Person> JsaEmail2People { get; set; }
        public virtual DbSet<JsaJobDescription> JsaJobDescriptions { get; set; }
        public virtual DbSet<JsaLocation> JsaLocations { get; set; }
        public virtual DbSet<JsaLocation2Business> JsaLocation2Businesses { get; set; }
        public virtual DbSet<JsaLocation2Person> JsaLocation2People { get; set; }
        public virtual DbSet<JsaOpportunity> JsaOpportunities { get; set; }
        public virtual DbSet<JsaOpportunityAction> JsaOpportunityActions { get; set; }
        public virtual DbSet<JsaOpportunityActionPerson> JsaOpportunityActionPeople { get; set; }
        public virtual DbSet<JsaOpportunityActionType> JsaOpportunityActionTypes { get; set; }
        public virtual DbSet<JsaOpportunityDocument> JsaOpportunityDocuments { get; set; }
        public virtual DbSet<JsaOpportunityWorkflow> JsaOpportunityWorkflows { get; set; }
        public virtual DbSet<JsaOpportunityWorkflowAction> JsaOpportunityWorkflowActions { get; set; }
        public virtual DbSet<JsaPerson> JsaPeople { get; set; }
        public virtual DbSet<JsaPerson2Business> JsaPerson2Businesses { get; set; }
        public virtual DbSet<JsaPhone> JsaPhones { get; set; }
        public virtual DbSet<JsaPhone2Business> JsaPhone2Businesses { get; set; }
        public virtual DbSet<JsaPhone2Person> JsaPhone2People { get; set; }
        public virtual DbSet<JsaResultCategory> JsaResultCategories { get; set; }
        public virtual DbSet<JsaResultStatus> JsaResultStatuses { get; set; }
        public virtual DbSet<JsaResume> JsaResumes { get; set; }
        public virtual DbSet<JsaSource> JsaSources { get; set; }
        public virtual DbSet<JsaSourceType> JsaSourceTypes { get; set; }
        public virtual DbSet<JsaUrl> JsaUrls { get; set; }
        public virtual DbSet<JsaUrl2Business> JsaUrl2Businesses { get; set; }
        public virtual DbSet<JsaUser> JsaUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BCO1FP1\\MSSQLAV;Database=JobSearchAssistant;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            //JSA Country
            modelBuilder.Entity<JsaCountry>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__c_Id");

                entity.ToTable("jsa_Country");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("c_Id");

                entity.Property(e => e.CCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("c_Code");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("c_Name");
            });

            modelBuilder.Entity<JsaLocation>(entity =>
            {
                entity.HasKey(e => e.LId)
                    .HasName("PK__l_Id");

                entity.ToTable("jsa_Location");

                entity.Property(e => e.LId)
                    .ValueGeneratedNever()
                    .HasColumnName("l_Id");

                entity.Property(e => e.LComments)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("l_Comments");

                entity.Property(e => e.LCountryId).HasColumnName("l_CountryId");

                entity.Property(e => e.LMunicipality)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("l_Municipality");

                entity.Property(e => e.LPostalCode)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("l_PostalCode");

                entity.Property(e => e.LProvince)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("l_Province");

                entity.Property(e => e.LStreetDirection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetDirection");

                entity.Property(e => e.LStreetLine1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetLine1");

                entity.Property(e => e.LStreetLine2)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetLine2");

                entity.Property(e => e.LStreetName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetName");

                entity.Property(e => e.LStreetNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetNumber");

                entity.Property(e => e.LStreetNumberSuffix)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetNumberSuffix");

                entity.Property(e => e.LStreetType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("l_StreetType");

                entity.Property(e => e.LUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("l_Unit");

                entity.HasOne(d => d.LCountry)
                    .WithMany(p => p.JsaLocations)
                    .HasForeignKey(d => d.LCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l_CountryId_2_c_Id");
            });

            modelBuilder.Entity<JsaBusiness>(entity =>
            {
                entity.HasKey(e => e.BId)
                    .HasName("PK__b_Id");

                entity.ToTable("jsa_Business");

                entity.Property(e => e.BId)
                    .ValueGeneratedNever()
                    .HasColumnName("b_Id");

                entity.Property(e => e.BName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("b_Name");
            });

            modelBuilder.Entity<JsaDocFormat>(entity =>
            {
                entity.HasKey(e => e.DfId)
                    .HasName("PK__df_Id");

                entity.ToTable("jsa_DocFormat");

                entity.Property(e => e.DfId)
                    .ValueGeneratedNever()
                    .HasColumnName("df_Id");

                entity.Property(e => e.DfType)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("df_Type");
            });

            modelBuilder.Entity<JsaDocument>(entity =>
            {
                entity.HasKey(e => e.DId)
                    .HasName("PK__d_Id");

                entity.ToTable("jsa_Document");

                entity.Property(e => e.DId)
                    .ValueGeneratedNever()
                    .HasColumnName("d_Id");

                entity.Property(e => e.DBody)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("d_Body");

                entity.Property(e => e.DDocFormatId).HasColumnName("d_DocFormatId");

                entity.Property(e => e.DEmailId).HasColumnName("d_EmailId");

                entity.Property(e => e.DFullPath)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("d_FullPath");

                entity.Property(e => e.DUrlId).HasColumnName("d_UrlId");

                entity.HasOne(d => d.DDocFormat)
                    .WithMany(p => p.JsaDocuments)
                    .HasForeignKey(d => d.DDocFormatId)
                    .HasConstraintName("FK__d_DocFormatId_2_df_Id");

                entity.HasOne(d => d.DEmail)
                    .WithMany(p => p.JsaDocuments)
                    .HasForeignKey(d => d.DEmailId)
                    .HasConstraintName("FK__d_EmailId_2_e_Id");

                entity.HasOne(d => d.DUrl)
                    .WithMany(p => p.JsaDocuments)
                    .HasForeignKey(d => d.DUrlId)
                    .HasConstraintName("FK__d_UrlId_2_u_Id");
            });

            modelBuilder.Entity<JsaEmail>(entity =>
            {
                entity.HasKey(e => e.EId)
                    .HasName("PK__e_Id");

                entity.ToTable("jsa_Email");

                entity.Property(e => e.EId)
                    .ValueGeneratedNever()
                    .HasColumnName("e_Id");

                entity.Property(e => e.EAddress)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("e_Address");

                entity.Property(e => e.EComment)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("e_Comment");
            });

            modelBuilder.Entity<JsaEmail2Business>(entity =>
            {
                entity.HasKey(e => e.E2bId)
                    .HasName("PK__e2b_Id");

                entity.ToTable("jsa_Email2Business");

                entity.Property(e => e.E2bId)
                    .ValueGeneratedNever()
                    .HasColumnName("e2b_Id");

                entity.Property(e => e.E2bActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("e2b_Active");

                entity.Property(e => e.E2bBusinessId).HasColumnName("e2b_BusinessId");

                entity.Property(e => e.E2bEmailId).HasColumnName("e2b_EmailId");

                entity.HasOne(d => d.E2bBusiness)
                    .WithMany(p => p.JsaEmail2Businesses)
                    .HasForeignKey(d => d.E2bBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_e2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.E2bEmail)
                    .WithMany(p => p.JsaEmail2Businesses)
                    .HasForeignKey(d => d.E2bEmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_e2b_EmailId_2_e_Id");
            });

            modelBuilder.Entity<JsaEmail2Person>(entity =>
            {
                entity.HasKey(e => e.E2pId)
                    .HasName("PK__e2p_Id");

                entity.ToTable("jsa_Email2Person");

                entity.Property(e => e.E2pId)
                    .ValueGeneratedNever()
                    .HasColumnName("e2p_Id");

                entity.Property(e => e.E2pActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("e2p_Active");

                entity.Property(e => e.E2pEmailId).HasColumnName("e2p_EmailId");

                entity.Property(e => e.E2pPersonId).HasColumnName("e2p_PersonId");

                entity.HasOne(d => d.E2pEmail)
                    .WithMany(p => p.JsaEmail2People)
                    .HasForeignKey(d => d.E2pEmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__e2p_EmailId_2_e_Id");

                entity.HasOne(d => d.E2pPerson)
                    .WithMany(p => p.JsaEmail2People)
                    .HasForeignKey(d => d.E2pPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__e2p_PersonId_2_p_Id");
            });

            modelBuilder.Entity<JsaJobDescription>(entity =>
            {
                entity.HasKey(e => e.JdId)
                    .HasName("PK__jd_Id");

                entity.ToTable("jsa_JobDescription");

                entity.Property(e => e.JdId)
                    .ValueGeneratedNever()
                    .HasColumnName("jd_Id");

                entity.Property(e => e.JdDocumentId).HasColumnName("jd_DocumentId");

                entity.Property(e => e.JdSourceId).HasColumnName("jd_SourceId");

                entity.HasOne(d => d.JdSource)
                    .WithMany(p => p.JsaJobDescriptions)
                    .HasForeignKey(d => d.JdSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__jd_SourceId_2_s_Id");
            });

            modelBuilder.Entity<JsaLocation2Business>(entity =>
            {
                entity.HasKey(e => e.L2bId)
                    .HasName("PK__l2b_Id");

                entity.ToTable("jsa_Location2Business");

                entity.Property(e => e.L2bId)
                    .ValueGeneratedNever()
                    .HasColumnName("l2b_Id");

                entity.Property(e => e.L2bBusinessId).HasColumnName("l2b_BusinessId");

                entity.Property(e => e.L2bLocationId).HasColumnName("l2b_LocationId");

                entity.Property(e => e.L2pActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("l2p_Active");

                entity.HasOne(d => d.L2bBusiness)
                    .WithMany(p => p.JsaLocation2Businesses)
                    .HasForeignKey(d => d.L2bBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.L2bLocation)
                    .WithMany(p => p.JsaLocation2Businesses)
                    .HasForeignKey(d => d.L2bLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2b_LocationId_2_l_Id");
            });

            modelBuilder.Entity<JsaLocation2Person>(entity =>
            {
                entity.HasKey(e => e.L2pId)
                    .HasName("PK__l2p_Id");

                entity.ToTable("jsa_Location2Person");

                entity.Property(e => e.L2pId)
                    .ValueGeneratedNever()
                    .HasColumnName("l2p_Id");

                entity.Property(e => e.L2pActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("l2p_Active");

                entity.Property(e => e.L2pLocationId).HasColumnName("l2p_LocationId");

                entity.Property(e => e.L2pPersonId).HasColumnName("l2p_PersonId");

                entity.HasOne(d => d.L2pLocation)
                    .WithMany(p => p.JsaLocation2People)
                    .HasForeignKey(d => d.L2pLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2p_LocationId_2_l_Id");

                entity.HasOne(d => d.L2pPerson)
                    .WithMany(p => p.JsaLocation2People)
                    .HasForeignKey(d => d.L2pPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__l2p_PersonId_2_p_Id");
            });

            modelBuilder.Entity<JsaOpportunity>(entity =>
            {
                entity.HasKey(e => e.OId)
                    .HasName("PK__o_Id");

                entity.ToTable("jsa_Opportunity");

                entity.Property(e => e.OId)
                    .ValueGeneratedNever()
                    .HasColumnName("o_Id");

                entity.Property(e => e.OActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("o_Active")
                    .IsFixedLength(true);

                entity.Property(e => e.OJobDescriptionId).HasColumnName("o_JobDescriptionId");

                entity.Property(e => e.OResumeId).HasColumnName("o_ResumeId");

                entity.HasOne(d => d.OJobDescription)
                    .WithMany(p => p.JsaOpportunities)
                    .HasForeignKey(d => d.OJobDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__o_JobDescriptionId_2_jd_Id");

                entity.HasOne(d => d.OResume)
                    .WithMany(p => p.JsaOpportunities)
                    .HasForeignKey(d => d.OResumeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__o_ResumeId_2_r_Id");
            });

            modelBuilder.Entity<JsaOpportunityAction>(entity =>
            {
                entity.HasKey(e => e.OaId)
                    .HasName("PK__oa_Id");

                entity.ToTable("jsa_OpportunityAction");

                entity.Property(e => e.OaId)
                    .ValueGeneratedNever()
                    .HasColumnName("oa_Id");

                entity.Property(e => e.OaActionResultStatusId).HasColumnName("oa_ActionResultStatusId");

                entity.Property(e => e.OaDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("oa_DateTime");

                entity.Property(e => e.OaDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("oa_Description");

                entity.Property(e => e.OaOpportunityActionTypeId).HasColumnName("oa_OpportunityActionTypeId");

                entity.Property(e => e.OaOpportunityDocumentId).HasColumnName("oa_OpportunityDocumentId");

                entity.HasOne(d => d.OaActionResultStatus)
                    .WithMany(p => p.JsaOpportunityActions)
                    .HasForeignKey(d => d.OaActionResultStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oa_ResultStatusId_2_rs_Id");

                entity.HasOne(d => d.OaOpportunityActionType)
                    .WithMany(p => p.JsaOpportunityActions)
                    .HasForeignKey(d => d.OaOpportunityActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oa_OpportunityActionTypeId_2_oat_Id");

                entity.HasOne(d => d.OaOpportunityDocument)
                    .WithMany(p => p.JsaOpportunityActions)
                    .HasForeignKey(d => d.OaOpportunityDocumentId)
                    .HasConstraintName("FK__oa_OpportunityDocumentId_2_od_Id");
            });

            modelBuilder.Entity<JsaOpportunityActionPerson>(entity =>
            {
                entity.HasKey(e => e.OapId)
                    .HasName("PK__oap_Id");

                entity.ToTable("jsa_OpportunityActionPeople");

                entity.Property(e => e.OapId)
                    .ValueGeneratedNever()
                    .HasColumnName("oap_Id");

                entity.Property(e => e.OapOpportunityActionId).HasColumnName("oap_OpportunityActionId");

                entity.Property(e => e.OapPersonId).HasColumnName("oap_PersonId");

                entity.HasOne(d => d.OapOpportunityAction)
                    .WithMany(p => p.JsaOpportunityActionPeople)
                    .HasForeignKey(d => d.OapOpportunityActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oap_OpportunityActionId_2_oa_Id");

                entity.HasOne(d => d.OapPerson)
                    .WithMany(p => p.JsaOpportunityActionPeople)
                    .HasForeignKey(d => d.OapPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oap_PersonId_2_p_Id");
            });

            modelBuilder.Entity<JsaOpportunityActionType>(entity =>
            {
                entity.HasKey(e => e.OatId)
                    .HasName("PK__oat_Id");

                entity.ToTable("jsa_OpportunityActionType");

                entity.Property(e => e.OatId)
                    .ValueGeneratedNever()
                    .HasColumnName("oat_Id");

                entity.Property(e => e.OatDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("oat_Description");

                entity.Property(e => e.OatNote)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("oat_Note");

                entity.Property(e => e.OatSequenceNumber).HasColumnName("oat_SequenceNumber");

                entity.Property(e => e.OatTitle)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("oat_Title");
            });

            modelBuilder.Entity<JsaOpportunityDocument>(entity =>
            {
                entity.HasKey(e => e.OdId)
                    .HasName("PK__od_Id");

                entity.ToTable("jsa_OpportunityDocument");

                entity.Property(e => e.OdId)
                    .ValueGeneratedNever()
                    .HasColumnName("od_Id");

                entity.Property(e => e.OdDocument).HasColumnName("od_Document");

                entity.Property(e => e.OdOpportunityId).HasColumnName("od_OpportunityId");

                entity.HasOne(d => d.OdOpportunity)
                    .WithMany(p => p.JsaOpportunityDocuments)
                    .HasForeignKey(d => d.OdOpportunityId)
                    .HasConstraintName("FK__od_OpportunityId_2_o_Id");
            });

            modelBuilder.Entity<JsaOpportunityWorkflow>(entity =>
            {
                entity.HasKey(e => e.OwId)
                    .HasName("PK__ow_Id");

                entity.ToTable("jsa_OpportunityWorkflow");

                entity.Property(e => e.OwId)
                    .ValueGeneratedNever()
                    .HasColumnName("ow_Id");

                entity.Property(e => e.OwDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ow_DateTime");

                entity.Property(e => e.OwDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("ow_Description");

                entity.Property(e => e.OwOpportunityId).HasColumnName("ow_OpportunityId");

                entity.Property(e => e.OwWorkFlowResultStatusId).HasColumnName("ow_WorkFlowResultStatusId");

                entity.HasOne(d => d.OwOpportunity)
                    .WithMany(p => p.JsaOpportunityWorkflows)
                    .HasForeignKey(d => d.OwOpportunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ow_OpportunityId_2_o_Id");

                entity.HasOne(d => d.OwWorkFlowResultStatus)
                    .WithMany(p => p.JsaOpportunityWorkflows)
                    .HasForeignKey(d => d.OwWorkFlowResultStatusId)
                    .HasConstraintName("FK_ow_WorkflowResultStatusId_2_rs_Id");
            });

            modelBuilder.Entity<JsaOpportunityWorkflowAction>(entity =>
            {
                entity.HasKey(e => e.OwaId)
                    .HasName("PK__owa_Id");

                entity.ToTable("jsa_OpportunityWorkflowAction");

                entity.Property(e => e.OwaId)
                    .ValueGeneratedNever()
                    .HasColumnName("owa_Id");

                entity.Property(e => e.OwaOpportunityActionId).HasColumnName("owa_OpportunityActionId");

                entity.Property(e => e.OwaOpportunityWorkflowId).HasColumnName("owa_OpportunityWorkflowId");

                entity.HasOne(d => d.OwaOpportunityAction)
                    .WithMany(p => p.JsaOpportunityWorkflowActions)
                    .HasForeignKey(d => d.OwaOpportunityActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__owa_OpportunityActionId_2_oa_Id");

                entity.HasOne(d => d.OwaOpportunityWorkflow)
                    .WithMany(p => p.JsaOpportunityWorkflowActions)
                    .HasForeignKey(d => d.OwaOpportunityWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__owa_OpportunityWorkflowId_2_ow_Id");
            });

            modelBuilder.Entity<JsaPerson>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__p_Id");

                entity.ToTable("jsa_Person");

                entity.Property(e => e.PId)
                    .ValueGeneratedNever()
                    .HasColumnName("p_Id");

                entity.Property(e => e.PComments)
                    .HasMaxLength(1028)
                    .IsUnicode(false)
                    .HasColumnName("p_Comments");

                entity.Property(e => e.PFirstName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("p_FirstName");

                entity.Property(e => e.PLastName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("p_LastName");

                entity.Property(e => e.PNickName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("p_NickName");

                entity.Property(e => e.PPosition)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("p_Position");

                entity.Property(e => e.PTitle)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("p_Title");
            });

            modelBuilder.Entity<JsaPerson2Business>(entity =>
            {
                entity.HasKey(e => e.P2bId)
                    .HasName("PK__p2b_Id");

                entity.ToTable("jsa_Person2Business");

                entity.Property(e => e.P2bId)
                    .ValueGeneratedNever()
                    .HasColumnName("p2b_Id");

                entity.Property(e => e.P2bActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("p2b_Active");

                entity.Property(e => e.P2bBusinessId).HasColumnName("p2b_BusinessId");

                entity.Property(e => e.P2bPersonId).HasColumnName("p2b_PersonId");

                entity.HasOne(d => d.P2bBusiness)
                    .WithMany(p => p.JsaPerson2Businesses)
                    .HasForeignKey(d => d.P2bBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__p2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.P2bPerson)
                    .WithMany(p => p.JsaPerson2Businesses)
                    .HasForeignKey(d => d.P2bPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__p2b_PersonId_2_p_Id");
            });

            modelBuilder.Entity<JsaPhone>(entity =>
            {
                entity.HasKey(e => e.PhId)
                    .HasName("PK__ph_Id");

                entity.ToTable("jsa_Phone");

                entity.Property(e => e.PhId)
                    .ValueGeneratedNever()
                    .HasColumnName("ph_Id");

                entity.Property(e => e.PhComment)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("ph_Comment");

                entity.Property(e => e.PhFax)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ph_Fax")
                    .IsFixedLength(true);

                entity.Property(e => e.PhName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("ph_Name");

                entity.Property(e => e.PhNumber)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("ph_Number");
            });

            modelBuilder.Entity<JsaPhone2Business>(entity =>
            {
                entity.HasKey(e => e.Ph2bId)
                    .HasName("PK__ph2b_Id");

                entity.ToTable("jsa_Phone2Business");

                entity.Property(e => e.Ph2bId)
                    .ValueGeneratedNever()
                    .HasColumnName("ph2b_Id");

                entity.Property(e => e.Ph2bActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ph2b_Active");

                entity.Property(e => e.Ph2bBusinessId).HasColumnName("ph2b_BusinessId");

                entity.Property(e => e.Ph2bPhoneId).HasColumnName("ph2b_PhoneId");

                entity.HasOne(d => d.Ph2bBusiness)
                    .WithMany(p => p.JsaPhone2Businesses)
                    .HasForeignKey(d => d.Ph2bBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.Ph2bPhone)
                    .WithMany(p => p.JsaPhone2Businesses)
                    .HasForeignKey(d => d.Ph2bPhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2b_PhoneId_2_ph_Id");
            });

            modelBuilder.Entity<JsaPhone2Person>(entity =>
            {
                entity.HasKey(e => e.Ph2pId)
                    .HasName("PK__ph2p_Id");

                entity.ToTable("jsa_Phone2Person");

                entity.Property(e => e.Ph2pId)
                    .ValueGeneratedNever()
                    .HasColumnName("ph2p_Id");

                entity.Property(e => e.Ph2pActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ph2p_Active");

                entity.Property(e => e.Ph2pPersonId).HasColumnName("ph2p_PersonId");

                entity.Property(e => e.Ph2pPhoneId).HasColumnName("ph2p_PhoneId");

                entity.HasOne(d => d.Ph2pPerson)
                    .WithMany(p => p.JsaPhone2People)
                    .HasForeignKey(d => d.Ph2pPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2p_PersonId_2_p_Id");

                entity.HasOne(d => d.Ph2pPhone)
                    .WithMany(p => p.JsaPhone2People)
                    .HasForeignKey(d => d.Ph2pPhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK__ph2p_PhoneId_2_ph_Id");
            });

            modelBuilder.Entity<JsaResultCategory>(entity =>
            {
                entity.HasKey(e => e.RcId)
                    .HasName("PK__rc_Id");

                entity.ToTable("jsa_ResultCategory");

                entity.Property(e => e.RcId)
                    .ValueGeneratedNever()
                    .HasColumnName("rc_Id");

                entity.Property(e => e.RcCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("rc_Code");

                entity.Property(e => e.RcName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("rc_Name");
            });

            modelBuilder.Entity<JsaResultStatus>(entity =>
            {
                entity.HasKey(e => e.RsId)
                    .HasName("PK__rs_Id");

                entity.ToTable("jsa_ResultStatus");

                entity.Property(e => e.RsId)
                    .ValueGeneratedNever()
                    .HasColumnName("rs_Id");

                entity.Property(e => e.RsCategoryId).HasColumnName("rs_CategoryId");

                entity.Property(e => e.RsCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("rs_Code");

                entity.Property(e => e.RsName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("rs_Name");

                entity.HasOne(d => d.RsCategory)
                    .WithMany(p => p.JsaResultStatuses)
                    .HasForeignKey(d => d.RsCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rs_CategoryId_2_rc_Id");
            });

            modelBuilder.Entity<JsaResume>(entity =>
            {
                entity.HasKey(e => e.RId)
                    .HasName("PK__r_Id");

                entity.ToTable("jsa_Resume");

                entity.Property(e => e.RId)
                    .ValueGeneratedNever()
                    .HasColumnName("r_id");

                entity.Property(e => e.RActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("r_Active");

                entity.Property(e => e.RDocumentId).HasColumnName("r_DocumentId");

                entity.Property(e => e.RSubVersion).HasColumnName("r_SubVersion");

                entity.Property(e => e.RVersion).HasColumnName("r_Version");

                entity.Property(e => e.RVersioningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("r_VersioningDate");
            });

            modelBuilder.Entity<JsaSource>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK__s_Id");

                entity.ToTable("jsa_Source");

                entity.Property(e => e.SId)
                    .ValueGeneratedNever()
                    .HasColumnName("s_Id");

                entity.Property(e => e.SComment)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("s_Comment");

                entity.Property(e => e.SEmailId).HasColumnName("s_EmailId");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("s_Name");

                entity.Property(e => e.SPersonId).HasColumnName("s_PersonId");

                entity.Property(e => e.SSourceTypeId).HasColumnName("s_SourceTypeId");

                entity.Property(e => e.SUrlId).HasColumnName("s_UrlId");

                entity.HasOne(d => d.SEmail)
                    .WithMany(p => p.JsaSources)
                    .HasForeignKey(d => d.SEmailId)
                    .HasConstraintName("FK_s_EmailId_2_e_Id");

                entity.HasOne(d => d.SPerson)
                    .WithMany(p => p.JsaSources)
                    .HasForeignKey(d => d.SPersonId)
                    .HasConstraintName("FK__s_PersonId_2_p_Id");

                entity.HasOne(d => d.SSourceType)
                    .WithMany(p => p.JsaSources)
                    .HasForeignKey(d => d.SSourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__s_SourceTypeId_2_st_Id");

                entity.HasOne(d => d.SUrl)
                    .WithMany(p => p.JsaSources)
                    .HasForeignKey(d => d.SUrlId)
                    .HasConstraintName("FK__s_UrlId_2_u_Id");
            });

            modelBuilder.Entity<JsaSourceType>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK__st_Id");

                entity.ToTable("jsa_SourceType");

                entity.Property(e => e.StId)
                    .ValueGeneratedNever()
                    .HasColumnName("st_ID");

                entity.Property(e => e.StType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_Type");

                entity.Property(e => e.StTypeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("st_TypeName");
            });

            modelBuilder.Entity<JsaUrl>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__u_Id");

                entity.ToTable("jsa_Url");

                entity.Property(e => e.UId)
                    .ValueGeneratedNever()
                    .HasColumnName("u_Id");

                entity.Property(e => e.UBody)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("u_Body");

                entity.Property(e => e.UComment)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("u_Comment");
            });

            modelBuilder.Entity<JsaUrl2Business>(entity =>
            {
                entity.HasKey(e => e.U2bId)
                    .HasName("PK__u2b_Id");

                entity.ToTable("jsa_Url2Business");

                entity.Property(e => e.U2bId)
                    .ValueGeneratedNever()
                    .HasColumnName("u2b_Id");

                entity.Property(e => e.U2bActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("u2b_Active");

                entity.Property(e => e.U2bBusinessId).HasColumnName("u2b_BusinessId");

                entity.Property(e => e.U2bUrlId).HasColumnName("u2b_UrlId");

                entity.HasOne(d => d.U2bBusiness)
                    .WithMany(p => p.JsaUrl2Businesses)
                    .HasForeignKey(d => d.U2bBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_u2b_BusinessId_2_b_Id");

                entity.HasOne(d => d.U2bUrl)
                    .WithMany(p => p.JsaUrl2Businesses)
                    .HasForeignKey(d => d.U2bUrlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_u2b_UrlId_2_u_Id");
            });

            modelBuilder.Entity<JsaUser>(entity =>
            {
                entity.HasKey(e => e.UsrId)
                    .HasName("PK__usr_Id");

                entity.ToTable("jsa_User");

                entity.Property(e => e.UsrId)
                    .ValueGeneratedNever()
                    .HasColumnName("usr_Id");

                entity.Property(e => e.UsrPersonId).HasColumnName("usr_PersonId");

                entity.HasOne(d => d.UsrPerson)
                    .WithMany(p => p.JsaUsers)
                    .HasForeignKey(d => d.UsrPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__usr_PersonId_2_p_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
