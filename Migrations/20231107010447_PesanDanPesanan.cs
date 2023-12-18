using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class PesanDanPesanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesanans");

            migrationBuilder.CreateTable(
                name: "Pesans",
                columns: table => new
                {
                    PesanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MakananId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalHarga = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesans", x => x.PesanId);
                    table.ForeignKey(
                        name: "FK_Pesans_Makanans_MakananId",
                        column: x => x.MakananId,
                        principalTable: "Makanans",
                        principalColumn: "MakananId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pesans_MakananId",
                table: "Pesans",
                column: "MakananId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesans");

            migrationBuilder.CreateTable(
                name: "Pesanans",
                columns: table => new
                {
                    PesananId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MakananId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalHarga = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesanans", x => x.PesananId);
                    table.ForeignKey(
                        name: "FK_Pesanans_Makanans_MakananId",
                        column: x => x.MakananId,
                        principalTable: "Makanans",
                        principalColumn: "MakananId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pesanans_MakananId",
                table: "Pesanans",
                column: "MakananId");
        }
    }
}
