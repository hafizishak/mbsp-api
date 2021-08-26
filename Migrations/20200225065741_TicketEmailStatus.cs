using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class TicketEmailStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailSend",
                table: "Ticket");

            migrationBuilder.AddColumn<bool>(
                name: "EmailStatus",
                table: "Ticket",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailStatus",
                table: "Ticket");

            migrationBuilder.AddColumn<bool>(
                name: "EmailSend",
                table: "Ticket",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
