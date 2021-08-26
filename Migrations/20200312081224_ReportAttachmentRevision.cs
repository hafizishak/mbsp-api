using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class ReportAttachmentRevision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Revision",
                table: "ReportAttachment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Revision",
                table: "ReportAttachment");
        }
    }
}
