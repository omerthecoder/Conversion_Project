using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Conversion_Project.DAL.Migrations
{
    public partial class mg18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataText",
                columns: table => new
                {
                    DataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Translated = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Translation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
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
