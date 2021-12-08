﻿// <auto-generated />
using System;
using JsaCqrsApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JsaCqrsApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211203215439_jsaCqrsApi_v1_1")]
    partial class jsaCqrsApi_v1_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JsaCqrsApi.Models.JsaBusiness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaBusiness");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaCountry");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DDocFormatId")
                        .HasColumnType("int");

                    b.Property<int?>("DEmailId")
                        .HasColumnType("int");

                    b.Property<string>("DFullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DUrlId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaDocument");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EComment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaEmail");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaEmail2Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("E2bActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("E2bBusinessId")
                        .HasColumnType("int");

                    b.Property<int>("E2bEmailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaEmail2Business");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaEmail2Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("E2pActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("E2pEmailId")
                        .HasColumnType("int");

                    b.Property<int>("E2pPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaEmail2Person");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaJobDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JdDocumentId")
                        .HasColumnType("int");

                    b.Property<int>("JdSourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaJobDescription");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LCountryId")
                        .HasColumnType("int");

                    b.Property<string>("LMunicipality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetDirection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetNumberSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LStreetType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LUnit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaLocation");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaLocation2Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("L2bBusinessId")
                        .HasColumnType("int");

                    b.Property<int>("L2bLocationId")
                        .HasColumnType("int");

                    b.Property<string>("L2pActive")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaLocation2Business");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaLocation2Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("L2pActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("L2pLocationId")
                        .HasColumnType("int");

                    b.Property<int>("L2pPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaLocation2Person");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OJobDescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("OResumeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunity");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunityAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OaActionResultStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OaDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OaOpportunityActionTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("OaOpportunityDocumentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunityAction");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunityActionPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OapOpportunityActionId")
                        .HasColumnType("int");

                    b.Property<int>("OapPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunityActionPerson");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunityActionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OatDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OatNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OatSequenceNumber")
                        .HasColumnType("int");

                    b.Property<string>("OatTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunityActionType");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunityDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OdDocument")
                        .HasColumnType("int");

                    b.Property<int?>("OdOpportunityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunityDocument");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunityWorkflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("OwDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwOpportunityId")
                        .HasColumnType("int");

                    b.Property<int?>("OwWorkFlowResultStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunityWorkflow");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaOpportunityWorkflowAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OwaOpportunityActionId")
                        .HasColumnType("int");

                    b.Property<int>("OwaOpportunityWorkflowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaOpportunityWorkflowAction");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PNickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaPerson");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaPerson2Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("P2bActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("P2bBusinessId")
                        .HasColumnType("int");

                    b.Property<int>("P2bPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaPerson2Business");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhFax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaPhone");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaPhone2Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ph2bActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ph2bBusinessId")
                        .HasColumnType("int");

                    b.Property<int>("Ph2bPhoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaPhone2Business");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaPhone2Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ph2pActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ph2pPersonId")
                        .HasColumnType("int");

                    b.Property<int>("Ph2pPhoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaPhone2Person");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaResultStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RsCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("RsCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaResultStatus");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaResume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RDocumentId")
                        .HasColumnType("int");

                    b.Property<int?>("RSubVersion")
                        .HasColumnType("int");

                    b.Property<int>("RVersion")
                        .HasColumnType("int");

                    b.Property<DateTime>("RVersioningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("JsaResume");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SEmailId")
                        .HasColumnType("int");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SPersonId")
                        .HasColumnType("int");

                    b.Property<int>("SSourceTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("SUrlId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaSource");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaSourceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaSourceType");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UComment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JsaUrl");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaUrl2Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("U2bActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("U2bBusinessId")
                        .HasColumnType("int");

                    b.Property<int>("U2bUrlId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaUrl2Business");
                });

            modelBuilder.Entity("JsaCqrsApi.Models.JsaUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UsrPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JsaUser");
                });
#pragma warning restore 612, 618
        }
    }
}
