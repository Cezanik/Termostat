using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ustaw_temperature.Data.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mieszkanie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiczbaOkien = table.Column<int>(type: "int", nullable: false),
                    LiczbaPokoi = table.Column<int>(type: "int", nullable: false),
                    BazowaTemperatura = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mieszkanie", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mieszkanie");
        }
    }
}
