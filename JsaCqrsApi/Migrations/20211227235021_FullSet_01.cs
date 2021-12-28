using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JsaCqrsApi.Migrations
{
    public partial class FullSet_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__c_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocFormat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__df_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 320, nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityActionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    SequenceNumber = table.Column<int>(nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 512, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 1024, nullable: true),
                    Note = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__oat_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    NickName = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    Position = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    Comments = table.Column<string>(unicode: false, maxLength: 1028, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Number = table.Column<string>(unicode: false, maxLength: 320, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    Fax = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ph_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BuyingPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ConfidentialData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rc_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    SubVersion = table.Column<int>(nullable: true),
                    VersioningDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__r_Id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SourceType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    TypeName = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__st_Id", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Url",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Body = table.Column<string>(unicode: false, maxLength: 2048, nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__u_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    StreetNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    StreetNumberSuffix = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    StreetName = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    StreetType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    StreetDirection = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Unit = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Municipality = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    Province = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    StreetLine1 = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    StreetLine2 = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    Comments = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__l_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__l_CountryId_2_c_Id",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Email2Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    EmailId = table.Column<int>(nullable: false),
                    BusinessId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e2b_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_e2b_BusinessId_2_b_Id",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_e2b_EmailId_2_e_Id",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Email2Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    EmailId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e2p_Id", x => x.Id);
                    table.ForeignKey(
                        name: "PK__e2p_EmailId_2_e_Id",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK__e2p_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person2Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    BusinessId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p2b_Id", x => x.Id);
                    table.ForeignKey(
                        name: "PK__p2b_BusinessId_2_b_Id",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK__p2b_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usr_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__usr_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jsa_Phone2Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ph2p_Id", x => x.Id);
                    table.ForeignKey(
                        name: "PK__ph2p_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK__ph2p_PhoneId_2_ph_Id",
                        column: x => x.PersonId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phone2Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false),
                    BusinessId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ph2b_Id", x => x.Id);
                    table.ForeignKey(
                        name: "PK__ph2b_BusinessId_2_b_Id",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK__ph2b_PhoneId_2_ph_Id",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rs_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__rs_CategoryId_2_rc_Id",
                        column: x => x.CategoryId,
                        principalTable: "ResultCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UrlId = table.Column<int>(nullable: true),
                    EmailId = table.Column<int>(nullable: true),
                    DocFormatId = table.Column<int>(nullable: true),
                    Body = table.Column<string>(unicode: false, maxLength: 8000, nullable: true),
                    FullPath = table.Column<string>(unicode: false, maxLength: 260, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__d_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__d_DocFormatId_2_df_Id",
                        column: x => x.DocFormatId,
                        principalTable: "DocFormat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__d_EmailId_2_e_Id",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__d_UrlId_2_u_Id",
                        column: x => x.UrlId,
                        principalTable: "Url",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    SourceTypeId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: true),
                    UrlId = table.Column<int>(nullable: true),
                    EmailId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 1024, nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_s_EmailId_2_e_Id",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__s_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__s_SourceTypeId_2_st_Id",
                        column: x => x.SourceTypeId,
                        principalTable: "SourceType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__s_UrlId_2_u_Id",
                        column: x => x.UrlId,
                        principalTable: "Url",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrlLink2Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UrlId = table.Column<int>(nullable: false),
                    BusinessId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__u2b_Id", x => x.Id);
                    table.ForeignKey(
                        name: "PK_u2b_BusinessId_2_b_Id",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PK_u2b_UrlId_2_u_Id",
                        column: x => x.UrlId,
                        principalTable: "Url",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location2Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BusinessId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__l2b_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__l2b_BusinessId_2_b_Id",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__l2b_LocationId_2_l_Id",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location2Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__l2p_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__l2p_LocationId_2_l_Id",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__l2p_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobDescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__jd_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__jd_SourceId_2_s_Id",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    JobDescriptionId = table.Column<int>(nullable: false),
                    ResumeId = table.Column<int>(nullable: false),
                    Active = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__o_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__o_JobDescriptionId_2_jd_Id",
                        column: x => x.JobDescriptionId,
                        principalTable: "JobDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__o_ResumeId_2_r_Id",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OpportunityId = table.Column<int>(nullable: true),
                    Document = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__od_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__od_OpportunityId_2_o_Id",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityWorkflow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OpportunityId = table.Column<int>(nullable: false),
                    WorkFlowResultStatusId = table.Column<int>(nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ow_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ow_OpportunityId_2_o_Id",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ow_WorkflowResultStatusId_2_rs_Id",
                        column: x => x.WorkFlowResultStatusId,
                        principalTable: "ResultStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityAction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OpportunityActionTypeId = table.Column<int>(nullable: false),
                    ActionResultStatusId = table.Column<int>(nullable: false),
                    OpportunityDocumentId = table.Column<int>(nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__oa_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__oa_ResultStatusId_2_rs_Id",
                        column: x => x.ActionResultStatusId,
                        principalTable: "ResultStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__oa_OpportunityActionTypeId_2_oat_Id",
                        column: x => x.OpportunityActionTypeId,
                        principalTable: "OpportunityActionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__oa_OpportunityDocumentId_2_od_Id",
                        column: x => x.OpportunityDocumentId,
                        principalTable: "OpportunityDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityActionPeople",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OpportunityActionId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__oap_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__oap_OpportunityActionId_2_oa_Id",
                        column: x => x.OpportunityActionId,
                        principalTable: "OpportunityAction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__oap_PersonId_2_p_Id",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityWorkflowAction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OpportunityWorkflowId = table.Column<int>(nullable: false),
                    OpportunityActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__owa_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK__owa_OpportunityActionId_2_oa_Id",
                        column: x => x.OpportunityActionId,
                        principalTable: "OpportunityAction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__owa_OpportunityWorkflowId_2_ow_Id",
                        column: x => x.OpportunityWorkflowId,
                        principalTable: "OpportunityWorkflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocFormatId",
                table: "Document",
                column: "DocFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_EmailId",
                table: "Document",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_UrlId",
                table: "Document",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_Email2Business_BusinessId",
                table: "Email2Business",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Email2Business_EmailId",
                table: "Email2Business",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Email2Person_EmailId",
                table: "Email2Person",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Email2Person_PersonId",
                table: "Email2Person",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDescription_SourceId",
                table: "JobDescription",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_jsa_Phone2Person_PersonId",
                table: "jsa_Phone2Person",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CountryId",
                table: "Location",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Location2Business_BusinessId",
                table: "Location2Business",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Location2Business_LocationId",
                table: "Location2Business",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location2Person_LocationId",
                table: "Location2Person",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location2Person_PersonId",
                table: "Location2Person",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_JobDescriptionId",
                table: "Opportunity",
                column: "JobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_ResumeId",
                table: "Opportunity",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityAction_ActionResultStatusId",
                table: "OpportunityAction",
                column: "ActionResultStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityAction_OpportunityActionTypeId",
                table: "OpportunityAction",
                column: "OpportunityActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityAction_OpportunityDocumentId",
                table: "OpportunityAction",
                column: "OpportunityDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityActionPeople_OpportunityActionId",
                table: "OpportunityActionPeople",
                column: "OpportunityActionId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityActionPeople_PersonId",
                table: "OpportunityActionPeople",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityDocument_OpportunityId",
                table: "OpportunityDocument",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityWorkflow_OpportunityId",
                table: "OpportunityWorkflow",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityWorkflow_WorkFlowResultStatusId",
                table: "OpportunityWorkflow",
                column: "WorkFlowResultStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityWorkflowAction_OpportunityActionId",
                table: "OpportunityWorkflowAction",
                column: "OpportunityActionId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityWorkflowAction_OpportunityWorkflowId",
                table: "OpportunityWorkflowAction",
                column: "OpportunityWorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_Person2Business_BusinessId",
                table: "Person2Business",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Person2Business_PersonId",
                table: "Person2Business",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone2Business_BusinessId",
                table: "Phone2Business",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone2Business_PhoneId",
                table: "Phone2Business",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultStatus_CategoryId",
                table: "ResultStatus",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Source_EmailId",
                table: "Source",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Source_PersonId",
                table: "Source",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Source_SourceTypeId",
                table: "Source",
                column: "SourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Source_UrlId",
                table: "Source",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_UrlLink2Business_BusinessId",
                table: "UrlLink2Business",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_UrlLink2Business_UrlId",
                table: "UrlLink2Business",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonId",
                table: "User",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Email2Business");

            migrationBuilder.DropTable(
                name: "Email2Person");

            migrationBuilder.DropTable(
                name: "jsa_Phone2Person");

            migrationBuilder.DropTable(
                name: "Location2Business");

            migrationBuilder.DropTable(
                name: "Location2Person");

            migrationBuilder.DropTable(
                name: "OpportunityActionPeople");

            migrationBuilder.DropTable(
                name: "OpportunityWorkflowAction");

            migrationBuilder.DropTable(
                name: "Person2Business");

            migrationBuilder.DropTable(
                name: "Phone2Business");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UrlLink2Business");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DocFormat");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "OpportunityAction");

            migrationBuilder.DropTable(
                name: "OpportunityWorkflow");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "OpportunityActionType");

            migrationBuilder.DropTable(
                name: "OpportunityDocument");

            migrationBuilder.DropTable(
                name: "ResultStatus");

            migrationBuilder.DropTable(
                name: "Opportunity");

            migrationBuilder.DropTable(
                name: "ResultCategory");

            migrationBuilder.DropTable(
                name: "JobDescription");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "SourceType");

            migrationBuilder.DropTable(
                name: "Url");
        }
    }
}
