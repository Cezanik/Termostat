using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ustaw_temperature.Data.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Liczniks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Liczniks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HarmonogramId = table.Column<int>(type: "int", nullable: false),
                    MieszkanieId = table.Column<int>(type: "int", nullable: false),
                    CenaDzienna = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liczniks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liczniks_Harmonogram_HarmonogramId",
                        column: x => x.HarmonogramId,
                        principalTable: "Harmonogram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Liczniks_Mieszkanie_MieszkanieId",
                        column: x => x.MieszkanieId,
                        principalTable: "Mieszkanie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Liczniks_HarmonogramId",
                table: "Liczniks",
                column: "HarmonogramId");

            migrationBuilder.CreateIndex(
                name: "IX_Liczniks_MieszkanieId",
                table: "Liczniks",
                column: "MieszkanieId");
        }
    }
}
