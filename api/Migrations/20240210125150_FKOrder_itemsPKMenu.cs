using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class FKOrder_itemsPKMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_items_Menu_MenuId",
                table: "Order_items");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Order_items");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Order_items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_items_Menu_MenuId",
                table: "Order_items",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_items_Menu_MenuId",
                table: "Order_items");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Order_items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Order_items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_items_Menu_MenuId",
                table: "Order_items",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id");
        }
    }
}
