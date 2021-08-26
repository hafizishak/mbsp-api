using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class UpdateIdmUploadMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdmUploadMachine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingNo = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    UploadStatus = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdmUploadMachine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdmUploadMachineDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BilNo = table.Column<string>(nullable: true),
                    Module = table.Column<string>(nullable: true),
                    MachineCode = table.Column<string>(nullable: true),
                    DieClassCode = table.Column<string>(nullable: true),
                    MachineConvert = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    MachineStatus = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IdmUploadMachineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdmUploadMachineDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdmUploadMachineDetail_IdmUploadMachine_IdmUploadMachineId",
                        column: x => x.IdmUploadMachineId,
                        principalTable: "IdmUploadMachine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdmUploadMachineDetail_IdmUploadMachineId",
                table: "IdmUploadMachineDetail",
                column: "IdmUploadMachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdmUploadMachineDetail");

            migrationBuilder.DropTable(
                name: "IdmUploadMachine");
        }
    }
}
