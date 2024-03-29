﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emeraude.Infrastructure.Localization.Migrations
{
    public partial class Init_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "content_keys",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    key = table.Column<string>(type: "TEXT", nullable: true, collation: "NOCASE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_content_keys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "keys",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    key = table.Column<string>(type: "TEXT", nullable: true, collation: "NOCASE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    code = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    native_name = table.Column<string>(type: "TEXT", nullable: true),
                    is_default = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "static_content",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    language_id = table.Column<int>(type: "INTEGER", nullable: false),
                    content_key_id = table.Column<int>(type: "INTEGER", nullable: false),
                    content = table.Column<string>(type: "TEXT", nullable: true, collation: "NOCASE"),
                    normalized_content = table.Column<string>(type: "TEXT", nullable: true, collation: "NOCASE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_static_content", x => x.id);
                    table.ForeignKey(
                        name: "FK_static_content_content_keys_content_key_id",
                        column: x => x.content_key_id,
                        principalTable: "content_keys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_static_content_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "values",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    language_id = table.Column<int>(type: "INTEGER", nullable: false),
                    translation_key_id = table.Column<int>(type: "INTEGER", nullable: false),
                    value = table.Column<string>(type: "TEXT", nullable: true, collation: "NOCASE"),
                    normalized_value = table.Column<string>(type: "TEXT", nullable: true, collation: "NOCASE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_values", x => x.id);
                    table.ForeignKey(
                        name: "FK_values_keys_translation_key_id",
                        column: x => x.translation_key_id,
                        principalTable: "keys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_values_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_content_keys_key",
                table: "content_keys",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_keys_key",
                table: "keys",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_languages_code",
                table: "languages",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_static_content_content_key_id",
                table: "static_content",
                column: "content_key_id");

            migrationBuilder.CreateIndex(
                name: "IX_static_content_language_id",
                table: "static_content",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_values_language_id",
                table: "values",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_values_translation_key_id",
                table: "values",
                column: "translation_key_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "static_content");

            migrationBuilder.DropTable(
                name: "values");

            migrationBuilder.DropTable(
                name: "content_keys");

            migrationBuilder.DropTable(
                name: "keys");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
