using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class AddLastEmailTriggerDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastEmailTriggerDate",
                table: "Verification",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "ReportAttachment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEmailTriggerDate",
                table: "ReoccurrencePreventions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEmailTriggerDate",
                table: "PreventiveActions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEmailTriggerDate",
                table: "ContainmentActions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastEmailTriggerDate",
                table: "Verification");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "ReportAttachment");

            migrationBuilder.DropColumn(
                name: "LastEmailTriggerDate",
                table: "ReoccurrencePreventions");

            migrationBuilder.DropColumn(
                name: "LastEmailTriggerDate",
                table: "PreventiveActions");

            migrationBuilder.DropColumn(
                name: "LastEmailTriggerDate",
                table: "ContainmentActions");
        }
    }
}
