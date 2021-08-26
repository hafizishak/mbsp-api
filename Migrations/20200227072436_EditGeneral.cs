using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class EditGeneral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.CreateTable(
                name: "GeneralData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerPrtNo = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CMSite = table.Column<string>(nullable: true),
                    CmName = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    LotNo = table.Column<string>(nullable: true),
                    Defect = table.Column<string>(nullable: true),
                    ManufacturingDateCode = table.Column<string>(nullable: true),
                    RejectInspectedLotQuantity = table.Column<string>(nullable: true),
                    ProblemDetectedArea = table.Column<string>(nullable: true),
                    BroadcomNotificationDate = table.Column<DateTime>(nullable: false),
                    NoOfSampleReturned = table.Column<int>(nullable: false),
                    SampleReceivedDate = table.Column<DateTime>(nullable: false),
                    PrtResponseDate = table.Column<DateTime>(nullable: false),
                    ReportId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralData_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralData_ReportId",
                table: "GeneralData",
                column: "ReportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralData");

            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BroadcomNotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CMSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CmName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPrtNo = table.Column<int>(type: "int", nullable: false),
                    Defect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingDateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfSampleReturned = table.Column<int>(type: "int", nullable: false),
                    ProblemDetectedArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrtResponseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RejectInspectedLotQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    SampleReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Id);
                    table.ForeignKey(
                        name: "FK_General_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_General_ReportId",
                table: "General",
                column: "ReportId");
        }
    }
}
