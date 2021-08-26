using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class EditReportAddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovalBy",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssueDate",
                table: "Report",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PRTNo",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreparedBy",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewedBy",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Revision",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RevisionDate",
                table: "Report",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Report",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalBy",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "IssueDate",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "PRTNo",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "PreparedBy",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "ReviewedBy",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "Revision",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "RevisionDate",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Report");
        }
    }
}
