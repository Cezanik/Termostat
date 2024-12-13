using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ustaw_temperature.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Mieszkanie",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uzytkownik",
                table: "Mieszkanie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uzytkownik2",
                table: "Mieszkanie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Mieszkanie_UserId",
                table: "Mieszkanie",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mieszkanie_AspNetUsers_UserId",
                table: "Mieszkanie",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mieszkanie_AspNetUsers_UserId",
                table: "Mieszkanie");

            migrationBuilder.DropIndex(
                name: "IX_Mieszkanie_UserId",
                table: "Mieszkanie");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Mieszkanie");

            migrationBuilder.DropColumn(
                name: "Uzytkownik",
                table: "Mieszkanie");

            migrationBuilder.DropColumn(
                name: "Uzytkownik2",
                table: "Mieszkanie");
        }
    }
}
