using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class MenuAndOrderItems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Order_items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_items_MenuId",
                table: "Order_items",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_items_Menu_MenuId",
                table: "Order_items",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_items_Menu_MenuId",
                table: "Order_items");

            migrationBuilder.DropIndex(
                name: "IX_Order_items_MenuId",
                table: "Order_items");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Order_items");
        }
    }
}
