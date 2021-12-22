using Microsoft.EntityFrameworkCore.Migrations;

namespace JsaCqrsApi.Migrations
{
    public partial class jsaCqrsApi_03_SourceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SourceType");
        }
    }
}
