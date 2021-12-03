using Microsoft.EntityFrameworkCore.Migrations;

namespace JsaCqrsApi.Migrations
{
    public partial class jsaCqrsApi_v1_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JsaEmailId",
                table: "JsaSource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JsaPersonId",
                table: "JsaSource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JsaSourceTypeId",
                table: "JsaSource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JsaUrlId",
                table: "JsaSource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JsaEmailId",
                table: "JsaDocument",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JsaUrlId",
                table: "JsaDocument",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JsaResultCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RcName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RcCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsaResultCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JsaUser_UsrPersonId",
                table: "JsaUser",
                column: "UsrPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaUrl2Business_U2bBusinessId",
                table: "JsaUrl2Business",
                column: "U2bBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaUrl2Business_U2bUrlId",
                table: "JsaUrl2Business",
                column: "U2bUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaSource_JsaEmailId",
                table: "JsaSource",
                column: "JsaEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaSource_JsaPersonId",
                table: "JsaSource",
                column: "JsaPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaSource_JsaSourceTypeId",
                table: "JsaSource",
                column: "JsaSourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaSource_JsaUrlId",
                table: "JsaSource",
                column: "JsaUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaResultStatus_RsCategoryId",
                table: "JsaResultStatus",
                column: "RsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaPhone2Person_Ph2pPersonId",
                table: "JsaPhone2Person",
                column: "Ph2pPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaPhone2Person_Ph2pPhoneId",
                table: "JsaPhone2Person",
                column: "Ph2pPhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaPhone2Business_Ph2bBusinessId",
                table: "JsaPhone2Business",
                column: "Ph2bBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaPhone2Business_Ph2bPhoneId",
                table: "JsaPhone2Business",
                column: "Ph2bPhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaPerson2Business_P2bBusinessId",
                table: "JsaPerson2Business",
                column: "P2bBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaPerson2Business_P2bPersonId",
                table: "JsaPerson2Business",
                column: "P2bPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityWorkflowAction_OwaOpportunityActionId",
                table: "JsaOpportunityWorkflowAction",
                column: "OwaOpportunityActionId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityWorkflowAction_OwaOpportunityWorkflowId",
                table: "JsaOpportunityWorkflowAction",
                column: "OwaOpportunityWorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityWorkflow_OwOpportunityId",
                table: "JsaOpportunityWorkflow",
                column: "OwOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityWorkflow_OwWorkFlowResultStatusId",
                table: "JsaOpportunityWorkflow",
                column: "OwWorkFlowResultStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityDocument_OdOpportunityId",
                table: "JsaOpportunityDocument",
                column: "OdOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityActionPerson_OapOpportunityActionId",
                table: "JsaOpportunityActionPerson",
                column: "OapOpportunityActionId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityActionPerson_OapPersonId",
                table: "JsaOpportunityActionPerson",
                column: "OapPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityAction_OaActionResultStatusId",
                table: "JsaOpportunityAction",
                column: "OaActionResultStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityAction_OaOpportunityActionTypeId",
                table: "JsaOpportunityAction",
                column: "OaOpportunityActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunityAction_OaOpportunityDocumentId",
                table: "JsaOpportunityAction",
                column: "OaOpportunityDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunity_OJobDescriptionId",
                table: "JsaOpportunity",
                column: "OJobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaOpportunity_OResumeId",
                table: "JsaOpportunity",
                column: "OResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaLocation2Person_L2pLocationId",
                table: "JsaLocation2Person",
                column: "L2pLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaLocation2Person_L2pPersonId",
                table: "JsaLocation2Person",
                column: "L2pPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaLocation2Business_L2bBusinessId",
                table: "JsaLocation2Business",
                column: "L2bBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaLocation2Business_L2bLocationId",
                table: "JsaLocation2Business",
                column: "L2bLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaLocation_LCountryId",
                table: "JsaLocation",
                column: "LCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaJobDescription_JdSourceId",
                table: "JsaJobDescription",
                column: "JdSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaEmail2Person_E2pEmailId",
                table: "JsaEmail2Person",
                column: "E2pEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaEmail2Person_E2pPersonId",
                table: "JsaEmail2Person",
                column: "E2pPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaEmail2Business_E2bBusinessId",
                table: "JsaEmail2Business",
                column: "E2bBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaEmail2Business_E2bEmailId",
                table: "JsaEmail2Business",
                column: "E2bEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaDocument_JsaEmailId",
                table: "JsaDocument",
                column: "JsaEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_JsaDocument_JsaUrlId",
                table: "JsaDocument",
                column: "JsaUrlId");

            migrationBuilder.AddForeignKey(
                name: "FK_JsaDocument_JsaEmail_JsaEmailId",
                table: "JsaDocument",
                column: "JsaEmailId",
                principalTable: "JsaEmail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaDocument_JsaUrl_JsaUrlId",
                table: "JsaDocument",
                column: "JsaUrlId",
                principalTable: "JsaUrl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaEmail2Business_JsaBusiness_E2bBusinessId",
                table: "JsaEmail2Business",
                column: "E2bBusinessId",
                principalTable: "JsaBusiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaEmail2Business_JsaEmail_E2bEmailId",
                table: "JsaEmail2Business",
                column: "E2bEmailId",
                principalTable: "JsaEmail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaEmail2Person_JsaEmail_E2pEmailId",
                table: "JsaEmail2Person",
                column: "E2pEmailId",
                principalTable: "JsaEmail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaEmail2Person_JsaPerson_E2pPersonId",
                table: "JsaEmail2Person",
                column: "E2pPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaJobDescription_JsaSource_JdSourceId",
                table: "JsaJobDescription",
                column: "JdSourceId",
                principalTable: "JsaSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaLocation_JsaCountry_LCountryId",
                table: "JsaLocation",
                column: "LCountryId",
                principalTable: "JsaCountry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaLocation2Business_JsaBusiness_L2bBusinessId",
                table: "JsaLocation2Business",
                column: "L2bBusinessId",
                principalTable: "JsaBusiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaLocation2Business_JsaLocation_L2bLocationId",
                table: "JsaLocation2Business",
                column: "L2bLocationId",
                principalTable: "JsaLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaLocation2Person_JsaLocation_L2pLocationId",
                table: "JsaLocation2Person",
                column: "L2pLocationId",
                principalTable: "JsaLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaLocation2Person_JsaPerson_L2pPersonId",
                table: "JsaLocation2Person",
                column: "L2pPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunity_JsaJobDescription_OJobDescriptionId",
                table: "JsaOpportunity",
                column: "OJobDescriptionId",
                principalTable: "JsaJobDescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunity_JsaResume_OResumeId",
                table: "JsaOpportunity",
                column: "OResumeId",
                principalTable: "JsaResume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityAction_JsaOpportunityActionType_OaOpportunityActionTypeId",
                table: "JsaOpportunityAction",
                column: "OaOpportunityActionTypeId",
                principalTable: "JsaOpportunityActionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityAction_JsaOpportunityDocument_OaOpportunityDocumentId",
                table: "JsaOpportunityAction",
                column: "OaOpportunityDocumentId",
                principalTable: "JsaOpportunityDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityAction_JsaResultStatus_OaActionResultStatusId",
                table: "JsaOpportunityAction",
                column: "OaActionResultStatusId",
                principalTable: "JsaResultStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityActionPerson_JsaOpportunityAction_OapOpportunityActionId",
                table: "JsaOpportunityActionPerson",
                column: "OapOpportunityActionId",
                principalTable: "JsaOpportunityAction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityActionPerson_JsaPerson_OapPersonId",
                table: "JsaOpportunityActionPerson",
                column: "OapPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityDocument_JsaOpportunity_OdOpportunityId",
                table: "JsaOpportunityDocument",
                column: "OdOpportunityId",
                principalTable: "JsaOpportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityWorkflow_JsaOpportunity_OwOpportunityId",
                table: "JsaOpportunityWorkflow",
                column: "OwOpportunityId",
                principalTable: "JsaOpportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityWorkflow_JsaResultStatus_OwWorkFlowResultStatusId",
                table: "JsaOpportunityWorkflow",
                column: "OwWorkFlowResultStatusId",
                principalTable: "JsaResultStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityWorkflowAction_JsaOpportunityAction_OwaOpportunityActionId",
                table: "JsaOpportunityWorkflowAction",
                column: "OwaOpportunityActionId",
                principalTable: "JsaOpportunityAction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaOpportunityWorkflowAction_JsaOpportunityWorkflow_OwaOpportunityWorkflowId",
                table: "JsaOpportunityWorkflowAction",
                column: "OwaOpportunityWorkflowId",
                principalTable: "JsaOpportunityWorkflow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaPerson2Business_JsaBusiness_P2bBusinessId",
                table: "JsaPerson2Business",
                column: "P2bBusinessId",
                principalTable: "JsaBusiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaPerson2Business_JsaPerson_P2bPersonId",
                table: "JsaPerson2Business",
                column: "P2bPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaPhone2Business_JsaBusiness_Ph2bBusinessId",
                table: "JsaPhone2Business",
                column: "Ph2bBusinessId",
                principalTable: "JsaBusiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaPhone2Business_JsaPhone_Ph2bPhoneId",
                table: "JsaPhone2Business",
                column: "Ph2bPhoneId",
                principalTable: "JsaPhone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaPhone2Person_JsaPerson_Ph2pPersonId",
                table: "JsaPhone2Person",
                column: "Ph2pPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaPhone2Person_JsaPhone_Ph2pPhoneId",
                table: "JsaPhone2Person",
                column: "Ph2pPhoneId",
                principalTable: "JsaPhone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaResultStatus_JsaResultCategory_RsCategoryId",
                table: "JsaResultStatus",
                column: "RsCategoryId",
                principalTable: "JsaResultCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaSource_JsaEmail_JsaEmailId",
                table: "JsaSource",
                column: "JsaEmailId",
                principalTable: "JsaEmail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaSource_JsaPerson_JsaPersonId",
                table: "JsaSource",
                column: "JsaPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaSource_JsaSourceType_JsaSourceTypeId",
                table: "JsaSource",
                column: "JsaSourceTypeId",
                principalTable: "JsaSourceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaSource_JsaUrl_JsaUrlId",
                table: "JsaSource",
                column: "JsaUrlId",
                principalTable: "JsaUrl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaUrl2Business_JsaBusiness_U2bBusinessId",
                table: "JsaUrl2Business",
                column: "U2bBusinessId",
                principalTable: "JsaBusiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaUrl2Business_JsaUrl_U2bUrlId",
                table: "JsaUrl2Business",
                column: "U2bUrlId",
                principalTable: "JsaUrl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JsaUser_JsaPerson_UsrPersonId",
                table: "JsaUser",
                column: "UsrPersonId",
                principalTable: "JsaPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JsaDocument_JsaEmail_JsaEmailId",
                table: "JsaDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaDocument_JsaUrl_JsaUrlId",
                table: "JsaDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaEmail2Business_JsaBusiness_E2bBusinessId",
                table: "JsaEmail2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaEmail2Business_JsaEmail_E2bEmailId",
                table: "JsaEmail2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaEmail2Person_JsaEmail_E2pEmailId",
                table: "JsaEmail2Person");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaEmail2Person_JsaPerson_E2pPersonId",
                table: "JsaEmail2Person");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaJobDescription_JsaSource_JdSourceId",
                table: "JsaJobDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaLocation_JsaCountry_LCountryId",
                table: "JsaLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaLocation2Business_JsaBusiness_L2bBusinessId",
                table: "JsaLocation2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaLocation2Business_JsaLocation_L2bLocationId",
                table: "JsaLocation2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaLocation2Person_JsaLocation_L2pLocationId",
                table: "JsaLocation2Person");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaLocation2Person_JsaPerson_L2pPersonId",
                table: "JsaLocation2Person");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunity_JsaJobDescription_OJobDescriptionId",
                table: "JsaOpportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunity_JsaResume_OResumeId",
                table: "JsaOpportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityAction_JsaOpportunityActionType_OaOpportunityActionTypeId",
                table: "JsaOpportunityAction");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityAction_JsaOpportunityDocument_OaOpportunityDocumentId",
                table: "JsaOpportunityAction");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityAction_JsaResultStatus_OaActionResultStatusId",
                table: "JsaOpportunityAction");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityActionPerson_JsaOpportunityAction_OapOpportunityActionId",
                table: "JsaOpportunityActionPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityActionPerson_JsaPerson_OapPersonId",
                table: "JsaOpportunityActionPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityDocument_JsaOpportunity_OdOpportunityId",
                table: "JsaOpportunityDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityWorkflow_JsaOpportunity_OwOpportunityId",
                table: "JsaOpportunityWorkflow");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityWorkflow_JsaResultStatus_OwWorkFlowResultStatusId",
                table: "JsaOpportunityWorkflow");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityWorkflowAction_JsaOpportunityAction_OwaOpportunityActionId",
                table: "JsaOpportunityWorkflowAction");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaOpportunityWorkflowAction_JsaOpportunityWorkflow_OwaOpportunityWorkflowId",
                table: "JsaOpportunityWorkflowAction");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaPerson2Business_JsaBusiness_P2bBusinessId",
                table: "JsaPerson2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaPerson2Business_JsaPerson_P2bPersonId",
                table: "JsaPerson2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaPhone2Business_JsaBusiness_Ph2bBusinessId",
                table: "JsaPhone2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaPhone2Business_JsaPhone_Ph2bPhoneId",
                table: "JsaPhone2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaPhone2Person_JsaPerson_Ph2pPersonId",
                table: "JsaPhone2Person");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaPhone2Person_JsaPhone_Ph2pPhoneId",
                table: "JsaPhone2Person");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaResultStatus_JsaResultCategory_RsCategoryId",
                table: "JsaResultStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaSource_JsaEmail_JsaEmailId",
                table: "JsaSource");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaSource_JsaPerson_JsaPersonId",
                table: "JsaSource");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaSource_JsaSourceType_JsaSourceTypeId",
                table: "JsaSource");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaSource_JsaUrl_JsaUrlId",
                table: "JsaSource");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaUrl2Business_JsaBusiness_U2bBusinessId",
                table: "JsaUrl2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaUrl2Business_JsaUrl_U2bUrlId",
                table: "JsaUrl2Business");

            migrationBuilder.DropForeignKey(
                name: "FK_JsaUser_JsaPerson_UsrPersonId",
                table: "JsaUser");

            migrationBuilder.DropTable(
                name: "JsaResultCategory");

            migrationBuilder.DropIndex(
                name: "IX_JsaUser_UsrPersonId",
                table: "JsaUser");

            migrationBuilder.DropIndex(
                name: "IX_JsaUrl2Business_U2bBusinessId",
                table: "JsaUrl2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaUrl2Business_U2bUrlId",
                table: "JsaUrl2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaSource_JsaEmailId",
                table: "JsaSource");

            migrationBuilder.DropIndex(
                name: "IX_JsaSource_JsaPersonId",
                table: "JsaSource");

            migrationBuilder.DropIndex(
                name: "IX_JsaSource_JsaSourceTypeId",
                table: "JsaSource");

            migrationBuilder.DropIndex(
                name: "IX_JsaSource_JsaUrlId",
                table: "JsaSource");

            migrationBuilder.DropIndex(
                name: "IX_JsaResultStatus_RsCategoryId",
                table: "JsaResultStatus");

            migrationBuilder.DropIndex(
                name: "IX_JsaPhone2Person_Ph2pPersonId",
                table: "JsaPhone2Person");

            migrationBuilder.DropIndex(
                name: "IX_JsaPhone2Person_Ph2pPhoneId",
                table: "JsaPhone2Person");

            migrationBuilder.DropIndex(
                name: "IX_JsaPhone2Business_Ph2bBusinessId",
                table: "JsaPhone2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaPhone2Business_Ph2bPhoneId",
                table: "JsaPhone2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaPerson2Business_P2bBusinessId",
                table: "JsaPerson2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaPerson2Business_P2bPersonId",
                table: "JsaPerson2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityWorkflowAction_OwaOpportunityActionId",
                table: "JsaOpportunityWorkflowAction");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityWorkflowAction_OwaOpportunityWorkflowId",
                table: "JsaOpportunityWorkflowAction");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityWorkflow_OwOpportunityId",
                table: "JsaOpportunityWorkflow");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityWorkflow_OwWorkFlowResultStatusId",
                table: "JsaOpportunityWorkflow");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityDocument_OdOpportunityId",
                table: "JsaOpportunityDocument");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityActionPerson_OapOpportunityActionId",
                table: "JsaOpportunityActionPerson");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityActionPerson_OapPersonId",
                table: "JsaOpportunityActionPerson");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityAction_OaActionResultStatusId",
                table: "JsaOpportunityAction");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityAction_OaOpportunityActionTypeId",
                table: "JsaOpportunityAction");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunityAction_OaOpportunityDocumentId",
                table: "JsaOpportunityAction");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunity_OJobDescriptionId",
                table: "JsaOpportunity");

            migrationBuilder.DropIndex(
                name: "IX_JsaOpportunity_OResumeId",
                table: "JsaOpportunity");

            migrationBuilder.DropIndex(
                name: "IX_JsaLocation2Person_L2pLocationId",
                table: "JsaLocation2Person");

            migrationBuilder.DropIndex(
                name: "IX_JsaLocation2Person_L2pPersonId",
                table: "JsaLocation2Person");

            migrationBuilder.DropIndex(
                name: "IX_JsaLocation2Business_L2bBusinessId",
                table: "JsaLocation2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaLocation2Business_L2bLocationId",
                table: "JsaLocation2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaLocation_LCountryId",
                table: "JsaLocation");

            migrationBuilder.DropIndex(
                name: "IX_JsaJobDescription_JdSourceId",
                table: "JsaJobDescription");

            migrationBuilder.DropIndex(
                name: "IX_JsaEmail2Person_E2pEmailId",
                table: "JsaEmail2Person");

            migrationBuilder.DropIndex(
                name: "IX_JsaEmail2Person_E2pPersonId",
                table: "JsaEmail2Person");

            migrationBuilder.DropIndex(
                name: "IX_JsaEmail2Business_E2bBusinessId",
                table: "JsaEmail2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaEmail2Business_E2bEmailId",
                table: "JsaEmail2Business");

            migrationBuilder.DropIndex(
                name: "IX_JsaDocument_JsaEmailId",
                table: "JsaDocument");

            migrationBuilder.DropIndex(
                name: "IX_JsaDocument_JsaUrlId",
                table: "JsaDocument");

            migrationBuilder.DropColumn(
                name: "JsaEmailId",
                table: "JsaSource");

            migrationBuilder.DropColumn(
                name: "JsaPersonId",
                table: "JsaSource");

            migrationBuilder.DropColumn(
                name: "JsaSourceTypeId",
                table: "JsaSource");

            migrationBuilder.DropColumn(
                name: "JsaUrlId",
                table: "JsaSource");

            migrationBuilder.DropColumn(
                name: "JsaEmailId",
                table: "JsaDocument");

            migrationBuilder.DropColumn(
                name: "JsaUrlId",
                table: "JsaDocument");
        }
    }
}
