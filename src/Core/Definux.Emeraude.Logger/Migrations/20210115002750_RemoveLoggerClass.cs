using Microsoft.EntityFrameworkCore.Migrations;

namespace Definux.Emeraude.Logger.Migrations
{
    public partial class RemoveLoggerClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "class",
                table: "error_logs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "class",
                table: "error_logs",
                type: "TEXT",
                nullable: true);
        }
    }
}
