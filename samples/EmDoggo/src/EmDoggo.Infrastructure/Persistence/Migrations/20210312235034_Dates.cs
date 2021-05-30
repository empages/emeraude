using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmDoggo.Infrastructure.Persistence.Migrations
{
    public partial class Dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OptionalDateTime",
                table: "Foods",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "OptionalDateTimeOffset",
                table: "Foods",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequiredDateTime",
                table: "Foods",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "RequiredDateTimeOffset",
                table: "Foods",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptionalDateTime",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OptionalDateTimeOffset",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "RequiredDateTime",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "RequiredDateTimeOffset",
                table: "Foods");
        }
    }
}
