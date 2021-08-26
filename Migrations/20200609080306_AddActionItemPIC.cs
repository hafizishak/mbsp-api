using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class AddActionItemPIC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionItemPIC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionItemId = table.Column<int>(nullable: false),
                    UserCode = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    ContainmentActionsId = table.Column<int>(nullable: true),
                    PreventiveActionsId = table.Column<int>(nullable: true),
                    ReoccurrencePreventionId = table.Column<int>(nullable: true),
                    VerificationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionItemPIC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionItemPIC_ContainmentActions_ContainmentActionsId",
                        column: x => x.ContainmentActionsId,
                        principalTable: "ContainmentActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionItemPIC_PreventiveActions_PreventiveActionsId",
                        column: x => x.PreventiveActionsId,
                        principalTable: "PreventiveActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionItemPIC_ReoccurrencePreventions_ReoccurrencePreventionId",
                        column: x => x.ReoccurrencePreventionId,
                        principalTable: "ReoccurrencePreventions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionItemPIC_Verification_VerificationId",
                        column: x => x.VerificationId,
                        principalTable: "Verification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionItemPIC_ContainmentActionsId",
                table: "ActionItemPIC",
                column: "ContainmentActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionItemPIC_PreventiveActionsId",
                table: "ActionItemPIC",
                column: "PreventiveActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionItemPIC_ReoccurrencePreventionId",
                table: "ActionItemPIC",
                column: "ReoccurrencePreventionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionItemPIC_VerificationId",
                table: "ActionItemPIC",
                column: "VerificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionItemPIC");
        }
    }
}
