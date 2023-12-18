using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class EditSeedTableMakanan3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 9,
                column: "PicturePath",
                value: "/images/TehTarik.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 9,
                column: "PicturePath",
                value: "/images/telorCeplok.jpg");
        }
    }
}
