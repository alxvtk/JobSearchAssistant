using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JsaCqrsApi.Migrations
{
    public partial class jsaCqrsApi_v1_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JsaBusiness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaBusiness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaCountry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaDocument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DUrlId = table.Column<int>(type: "int", nullable: true),
                    DEmailId = table.Column<int>(type: "int", nullable: true),
                    DDocFormatId = table.Column<int>(type: "int", nullable: true),
                    DBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFullPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaDocument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaEmail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaEmail2Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    E2bEmailId = table.Column<int>(type: "int", nullable: false),
                    E2bBusinessId = table.Column<int>(type: "int", nullable: false),
                    E2bActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaEmail2Business", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaEmail2Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    E2pEmailId = table.Column<int>(type: "int", nullable: false),
                    E2pPersonId = table.Column<int>(type: "int", nullable: false),
                    E2pActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaEmail2Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaJobDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JdSourceId = table.Column<int>(type: "int", nullable: false),
                    JdDocumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaJobDescription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LStreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LStreetNumberSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LStreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LStreetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LStreetDirection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LMunicipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LCountryId = table.Column<int>(type: "int", nullable: false),
                    LPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LStreetLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LStreetLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LComments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaLocation2Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L2bBusinessId = table.Column<int>(type: "int", nullable: false),
                    L2bLocationId = table.Column<int>(type: "int", nullable: false),
                    L2pActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaLocation2Business", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaLocation2Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L2pPersonId = table.Column<int>(type: "int", nullable: false),
                    L2pLocationId = table.Column<int>(type: "int", nullable: false),
                    L2pActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaLocation2Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OJobDescriptionId = table.Column<int>(type: "int", nullable: false),
                    OResumeId = table.Column<int>(type: "int", nullable: false),
                    OActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunityAction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OaOpportunityActionTypeId = table.Column<int>(type: "int", nullable: false),
                    OaActionResultStatusId = table.Column<int>(type: "int", nullable: false),
                    OaOpportunityDocumentId = table.Column<int>(type: "int", nullable: true),
                    OaDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunityAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunityActionPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OapOpportunityActionId = table.Column<int>(type: "int", nullable: false),
                    OapPersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunityActionPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunityActionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OatSequenceNumber = table.Column<int>(type: "int", nullable: false),
                    OatTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OatDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OatNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunityActionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunityDocument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdOpportunityId = table.Column<int>(type: "int", nullable: true),
                    OdDocument = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunityDocument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunityWorkflow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwOpportunityId = table.Column<int>(type: "int", nullable: false),
                    OwWorkFlowResultStatusId = table.Column<int>(type: "int", nullable: true),
                    OwDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunityWorkflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaOpportunityWorkflowAction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwaOpportunityWorkflowId = table.Column<int>(type: "int", nullable: false),
                    OwaOpportunityActionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaOpportunityWorkflowAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PNickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PComments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaPerson2Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P2bPersonId = table.Column<int>(type: "int", nullable: false),
                    P2bBusinessId = table.Column<int>(type: "int", nullable: false),
                    P2bActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaPerson2Business", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaPhone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaPhone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaPhone2Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ph2bPhoneId = table.Column<int>(type: "int", nullable: false),
                    Ph2bBusinessId = table.Column<int>(type: "int", nullable: false),
                    Ph2bActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaPhone2Business", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaPhone2Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ph2pPhoneId = table.Column<int>(type: "int", nullable: false),
                    Ph2pPersonId = table.Column<int>(type: "int", nullable: false),
                    Ph2pActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaPhone2Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaResultStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RsCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaResultStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaResume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RDocumentId = table.Column<int>(type: "int", nullable: false),
                    RVersion = table.Column<int>(type: "int", nullable: false),
                    RSubVersion = table.Column<int>(type: "int", nullable: true),
                    RVersioningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaResume", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaSource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSourceTypeId = table.Column<int>(type: "int", nullable: false),
                    SPersonId = table.Column<int>(type: "int", nullable: true),
                    SUrlId = table.Column<int>(type: "int", nullable: true),
                    SEmailId = table.Column<int>(type: "int", nullable: true),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaSourceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaSourceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaUrl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaUrl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaUrl2Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U2bUrlId = table.Column<int>(type: "int", nullable: false),
                    U2bBusinessId = table.Column<int>(type: "int", nullable: false),
                    U2bActive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaUrl2Business", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JsaUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsrPersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaUser", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsaBusiness");

            migrationBuilder.DropTable(
                name: "JsaCountry");

            migrationBuilder.DropTable(
                name: "JsaDocument");

            migrationBuilder.DropTable(
                name: "JsaEmail");

            migrationBuilder.DropTable(
                name: "JsaEmail2Business");

            migrationBuilder.DropTable(
                name: "JsaEmail2Person");

            migrationBuilder.DropTable(
                name: "JsaJobDescription");

            migrationBuilder.DropTable(
                name: "JsaLocation");

            migrationBuilder.DropTable(
                name: "JsaLocation2Business");

            migrationBuilder.DropTable(
                name: "JsaLocation2Person");

            migrationBuilder.DropTable(
                name: "JsaOpportunity");

            migrationBuilder.DropTable(
                name: "JsaOpportunityAction");

            migrationBuilder.DropTable(
                name: "JsaOpportunityActionPerson");

            migrationBuilder.DropTable(
                name: "JsaOpportunityActionType");

            migrationBuilder.DropTable(
                name: "JsaOpportunityDocument");

            migrationBuilder.DropTable(
                name: "JsaOpportunityWorkflow");

            migrationBuilder.DropTable(
                name: "JsaOpportunityWorkflowAction");

            migrationBuilder.DropTable(
                name: "JsaPerson");

            migrationBuilder.DropTable(
                name: "JsaPerson2Business");

            migrationBuilder.DropTable(
                name: "JsaPhone");

            migrationBuilder.DropTable(
                name: "JsaPhone2Business");

            migrationBuilder.DropTable(
                name: "JsaPhone2Person");

            migrationBuilder.DropTable(
                name: "JsaResultStatus");

            migrationBuilder.DropTable(
                name: "JsaResume");

            migrationBuilder.DropTable(
                name: "JsaSource");

            migrationBuilder.DropTable(
                name: "JsaSourceType");

            migrationBuilder.DropTable(
                name: "JsaUrl");

            migrationBuilder.DropTable(
                name: "JsaUrl2Business");

            migrationBuilder.DropTable(
                name: "JsaUser");
        }
    }
}
