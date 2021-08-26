using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iaf.API.Migrations
{
    public partial class OrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistory_Order_OrderId",
                table: "OrderHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderHistory_OrderId",
                table: "OrderHistory");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailId",
                table: "OrderItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailId",
                table: "OrderHistory",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingNo = table.Column<string>(nullable: true),
                    OrderBy = table.Column<string>(nullable: true),
                    Plant = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Sequence = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderDetailId",
                table: "OrderItem",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistory_OrderDetailId",
                table: "OrderHistory",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistory_OrderDetail_OrderDetailId",
                table: "OrderHistory",
                column: "OrderDetailId",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_OrderDetail_OrderDetailId",
                table: "OrderItem",
                column: "OrderDetailId",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistory_OrderDetail_OrderDetailId",
                table: "OrderHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_OrderDetail_OrderDetailId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderDetailId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderHistory_OrderDetailId",
                table: "OrderHistory");

            migrationBuilder.DropColumn(
                name: "OrderDetailId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "OrderDetailId",
                table: "OrderHistory");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistory_OrderId",
                table: "OrderHistory",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistory_Order_OrderId",
                table: "OrderHistory",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
