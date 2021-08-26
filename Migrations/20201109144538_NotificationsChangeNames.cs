using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class NotificationsChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Notification");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
