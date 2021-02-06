using Microsoft.EntityFrameworkCore.Migrations;

namespace EmDoggo.Infrastructure.Persistance.Migrations
{
    public partial class AddDescriptionToShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Shops",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Shops");
        }
    }
}
