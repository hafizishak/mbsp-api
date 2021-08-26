using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class Mrp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdmInventoryDTO",
                columns: table => new
                {
                    BusinessUnit = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ItemPartNo = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    MachineRunning = table.Column<int>(nullable: false),
                    Reorder = table.Column<string>(nullable: true),
                    QuantityIn = table.Column<int>(nullable: false),
                    QuantityOut = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MachineStatusGroupDTO",
                columns: table => new
                {
                    MachineCode = table.Column<string>(nullable: true),
                    MachineStatus = table.Column<string>(nullable: true),
                    TotalMC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MrpInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(nullable: true),
                    MrpType = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    RoutingType = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrpInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalMachineDieClassDTO",
                columns: table => new
                {
                    CarrierTape = table.Column<string>(nullable: true),
                    DieClassCode = table.Column<string>(nullable: true),
                    TotalMC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MrpApproval",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MrpInfoId = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    DepartmentCode = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrpApproval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MrpApproval_MrpInfo_MrpInfoId",
                        column: x => x.MrpInfoId,
                        principalTable: "MrpInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MrpAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    MrpInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrpAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MrpAttachment_MrpInfo_MrpInfoId",
                        column: x => x.MrpInfoId,
                        principalTable: "MrpInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MrpDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MrpInfoId = table.Column<int>(nullable: false),
                    Matl = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true),
                    VendorCode = table.Column<string>(nullable: true),
                    CPN = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    OpenPO = table.Column<int>(nullable: false),
                    TotalDemand = table.Column<int>(nullable: false),
                    Planned = table.Column<int>(nullable: false),
                    LeadTime = table.Column<int>(nullable: false),
                    SafetyLevel = table.Column<int>(nullable: false),
                    CustomerAdditionalBufferRequest = table.Column<int>(nullable: false),
                    SpqAndMoq = table.Column<int>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    UnitCost = table.Column<float>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrpDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MrpDetail_MrpInfo_MrpInfoId",
                        column: x => x.MrpInfoId,
                        principalTable: "MrpInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MrpApproval_MrpInfoId",
                table: "MrpApproval",
                column: "MrpInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MrpAttachment_MrpInfoId",
                table: "MrpAttachment",
                column: "MrpInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MrpDetail_MrpInfoId",
                table: "MrpDetail",
                column: "MrpInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdmInventoryDTO");

            migrationBuilder.DropTable(
                name: "MachineStatusGroupDTO");

            migrationBuilder.DropTable(
                name: "MrpApproval");

            migrationBuilder.DropTable(
                name: "MrpAttachment");

            migrationBuilder.DropTable(
                name: "MrpDetail");

            migrationBuilder.DropTable(
                name: "TotalMachineDieClassDTO");

            migrationBuilder.DropTable(
                name: "MrpInfo");
        }
    }
}
