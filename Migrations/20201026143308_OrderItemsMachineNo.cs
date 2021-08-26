using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class OrderItemsMachineNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineNo",
                table: "IdmItem");

            migrationBuilder.AddColumn<string>(
                name: "MachineNo",
                table: "OrderItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineNo",
                table: "OrderItem");

            migrationBuilder.AddColumn<string>(
                name: "MachineNo",
                table: "IdmItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
