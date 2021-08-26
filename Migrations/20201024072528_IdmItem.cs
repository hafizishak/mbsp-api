using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class IdmItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdmItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnit = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ItemPartNo = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    BalanceQuantity = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    ExpiredOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdmItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdmItem");
        }
    }
}
