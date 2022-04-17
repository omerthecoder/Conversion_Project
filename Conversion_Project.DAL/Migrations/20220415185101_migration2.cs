using Microsoft.EntityFrameworkCore.Migrations;

namespace Conversion_Project.DAL.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataStr",
                table: "DataText",
                newName: "Translated");

            migrationBuilder.RenameColumn(
                name: "DataResult",
                table: "DataText",
                newName: "Text");

            migrationBuilder.AddColumn<string>(
                name: "Translation",
                table: "DataText",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Translation",
                table: "DataText");

            migrationBuilder.RenameColumn(
                name: "Translated",
                table: "DataText",
                newName: "DataStr");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "DataText",
                newName: "DataResult");
        }
    }
}
