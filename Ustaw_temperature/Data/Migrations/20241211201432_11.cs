using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ustaw_temperature.Data.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocelowaTemperatura",
                table: "Harmonogram",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocelowaTemperatura",
                table: "Harmonogram");
        }
    }
}
