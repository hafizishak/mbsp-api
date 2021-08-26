using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class EditGroupAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupCode",
                table: "RoleAccessCode");

            migrationBuilder.AddColumn<string>(
                name: "AccessCode",
                table: "RoleAccessCode",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessCode",
                table: "RoleAccessCode");

            migrationBuilder.AddColumn<string>(
                name: "GroupCode",
                table: "RoleAccessCode",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
