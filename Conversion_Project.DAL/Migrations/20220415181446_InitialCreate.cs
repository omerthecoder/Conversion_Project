using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Conversion_Project.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataText",
                columns: table => new
                {
                    DataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataStr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    DataResult = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataText", x => x.DataId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataText");
        }
    }
}
