using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class FirstDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Makanans",
                columns: table => new
                {
                    MakananId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakananNama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harga = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makanans", x => x.MakananId);
                });

            migrationBuilder.CreateTable(
                name: "Pesanans",
                columns: table => new
                {
                    PesananId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakananId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalHarga = table.Column<float>(type: "real", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesanans");

            migrationBuilder.DropTable(
                name: "Makanans");
        }
    }
}
