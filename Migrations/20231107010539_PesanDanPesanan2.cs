using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class PesanDanPesanan2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pesananId",
                table: "Pesans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pesanans",
                columns: table => new
                {
                    pesananId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesanans", x => x.pesananId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pesans_pesananId",
                table: "Pesans",
                column: "pesananId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pesans_Pesanans_pesananId",
                table: "Pesans",
                column: "pesananId",
                principalTable: "Pesanans",
                principalColumn: "pesananId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pesans_Pesanans_pesananId",
                table: "Pesans");

            migrationBuilder.DropTable(
                name: "Pesanans");

            migrationBuilder.DropIndex(
                name: "IX_Pesans_pesananId",
                table: "Pesans");

            migrationBuilder.DropColumn(
                name: "pesananId",
                table: "Pesans");
        }
    }
}
