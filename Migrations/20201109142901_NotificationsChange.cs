using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class NotificationsChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(name:"IX_Notification_UserCode_GroupCode",table:"Notification");      
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
