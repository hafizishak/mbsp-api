using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class UpdateIdmRackDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumn",
                table: "IdmRackDetail");

            migrationBuilder.AddColumn<string>(
                name: "RackColumnEight",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnEleven",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnFive",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnFour",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnNine",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnOne",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnSeven",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnSix",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnTen",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnThree",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnTwelve",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumnTwo",
                table: "IdmRackDetail",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MasterCarrierTapeDieClassDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BusinessUnit = table.Column<string>(nullable: true),
                    DieClassCode = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ItemPartNo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterCarrierTapeDieClassDTO");

            migrationBuilder.DropColumn(
                name: "RackColumnEight",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnEleven",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnFive",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnFour",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnNine",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnOne",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnSeven",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnSix",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnTen",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnThree",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnTwelve",
                table: "IdmRackDetail");

            migrationBuilder.DropColumn(
                name: "RackColumnTwo",
                table: "IdmRackDetail");

            migrationBuilder.AddColumn<string>(
                name: "ItemCode",
                table: "IdmRackDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RackColumn",
                table: "IdmRackDetail",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
