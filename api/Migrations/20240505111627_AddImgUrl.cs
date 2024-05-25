using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_WorkerInfos_WorkerInfoId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "WorkerInfos");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorkerInfoId",
                table: "Workers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a3ee15e-2841-444e-a9d1-80a1ffcaebf4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd14d8f1-22eb-4d03-86a9-90c57330dcf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc0b85b-971b-4f16-be38-2042caa0300b");

            migrationBuilder.DropColumn(
                name: "WorkerInfoId",
                table: "Workers");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37df55cf-7e9b-4c29-9658-5cbebb39e8f7", null, "Admin", "ADMIN" },
                    { "c642292a-c091-493d-a296-3675bec2a3e4", null, "User", "USER" },
                    { "f100782d-fdbb-4973-ac14-250124835786", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37df55cf-7e9b-4c29-9658-5cbebb39e8f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c642292a-c091-493d-a296-3675bec2a3e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f100782d-fdbb-4973-ac14-250124835786");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Menu");

            migrationBuilder.AddColumn<int>(
                name: "WorkerInfoId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkerInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a3ee15e-2841-444e-a9d1-80a1ffcaebf4", null, "Admin", "ADMIN" },
                    { "dd14d8f1-22eb-4d03-86a9-90c57330dcf8", null, "User", "USER" },
                    { "ebc0b85b-971b-4f16-be38-2042caa0300b", null, "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorkerInfoId",
                table: "Workers",
                column: "WorkerInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_WorkerInfos_WorkerInfoId",
                table: "Workers",
                column: "WorkerInfoId",
                principalTable: "WorkerInfos",
                principalColumn: "Id");
        }
    }
}
