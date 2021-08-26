using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class UserDepartmentSectionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DivisionSection",
                table: "TicketApprover",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "TicketApproval",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DivisionSection",
                table: "TicketApprover");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "TicketApproval");
        }
    }
}
