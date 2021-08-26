using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class IdmRack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdmRack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RackLabel = table.Column<string>(nullable: true),
                    Plant = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdmRack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdmRackDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RackRow = table.Column<string>(nullable: true),
                    RackColumn = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IdmRackId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdmRackDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdmRackDetail_IdmRack_IdmRackId",
                        column: x => x.IdmRackId,
                        principalTable: "IdmRack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdmRackDetail_IdmRackId",
                table: "IdmRackDetail",
                column: "IdmRackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdmRackDetail");

            migrationBuilder.DropTable(
                name: "IdmRack");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Users");
        }
    }
}
