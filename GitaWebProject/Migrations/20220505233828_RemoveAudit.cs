using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitaWebProject.Migrations
{
    public partial class RemoveAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Production",
                table: "DeletedProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Production",
                table: "UserChanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                schema: "Production",
                table: "UserChanges",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Production",
                table: "UserChanges",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Production",
                table: "DeletedProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                schema: "Production",
                table: "DeletedProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Production",
                table: "DeletedProducts",
                type: "datetime2",
                nullable: true);
        }
    }
}
