using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class PesanDanPesanan3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalHarga",
                table: "Pesans");

            migrationBuilder.AddColumn<float>(
                name: "TotalHarga",
                table: "Pesanans",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalHarga",
                table: "Pesanans");

            migrationBuilder.AddColumn<float>(
                name: "TotalHarga",
                table: "Pesans",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
