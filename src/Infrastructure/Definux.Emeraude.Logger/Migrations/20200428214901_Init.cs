﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Definux.Emeraude.Logger.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "activity_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    action = table.Column<string>(nullable: true),
                    controller = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    parameters = table.Column<string>(nullable: true),
                    headers = table.Column<string>(nullable: true),
                    route = table.Column<string>(nullable: true),
                    method = table.Column<string>(nullable: true),
                    trace_id = table.Column<string>(nullable: true),
                    user_agent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activity_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "email_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    receiver = table.Column<string>(nullable: true),
                    subject = table.Column<string>(nullable: true),
                    body = table.Column<string>(nullable: true),
                    sent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "error_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    stack_trace = table.Column<string>(nullable: true),
                    source = table.Column<string>(nullable: true),
                    message = table.Column<string>(nullable: true),
                    method = table.Column<string>(nullable: true),
                    @class = table.Column<string>(name: "class", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_error_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "temp_file_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    path = table.Column<string>(nullable: true),
                    file_type = table.Column<int>(nullable: false),
                    file_extension = table.Column<int>(nullable: false),
                    applied = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temp_file_logs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activity_logs");

            migrationBuilder.DropTable(
                name: "email_logs");

            migrationBuilder.DropTable(
                name: "error_logs");

            migrationBuilder.DropTable(
                name: "temp_file_logs");
        }
    }
}
