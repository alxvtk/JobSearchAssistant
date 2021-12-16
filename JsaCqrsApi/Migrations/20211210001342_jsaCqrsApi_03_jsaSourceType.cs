using Microsoft.EntityFrameworkCore.Migrations;

namespace JsaCqrsApi.Migrations
{
    public partial class jsaCqrsApi_03_jsaSourceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jsa_SourceType",
                columns: table => new
                {
                    st_ID = table.Column<int>(nullable: false),
                    st_Type = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    st_TypeName = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__st_Id", x => x.st_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jsa_SourceType");
        }
    }
}
