using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4adb49fc-0f63-4d25-9464-a69de1ac74f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa83e154-aa1c-4e8c-848d-080ae062ab6e");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16747a9b-147c-4efb-bbe9-2282caeaf8d1", null, "Admin", "Admin" },
                    { "5f0d8ff6-2fd1-405c-b55a-06751875103b", null, "User", "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16747a9b-147c-4efb-bbe9-2282caeaf8d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f0d8ff6-2fd1-405c-b55a-06751875103b");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4adb49fc-0f63-4d25-9464-a69de1ac74f8", null, "Admin", "Admin" },
                    { "fa83e154-aa1c-4e8c-848d-080ae062ab6e", null, "User", "User" }
                });
        }
    }
}
