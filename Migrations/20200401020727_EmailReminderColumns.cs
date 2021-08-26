using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class EmailReminderColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmailReminder",
                table: "Verification",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmailReminder",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmailReminder",
                table: "ReoccurrencePreventions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmailReminder",
                table: "PreventiveActions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmailReminder",
                table: "ContainmentActions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailReminder",
                table: "Verification");

            migrationBuilder.DropColumn(
                name: "EmailReminder",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "EmailReminder",
                table: "ReoccurrencePreventions");

            migrationBuilder.DropColumn(
                name: "EmailReminder",
                table: "PreventiveActions");

            migrationBuilder.DropColumn(
                name: "EmailReminder",
                table: "ContainmentActions");
        }
    }
}
