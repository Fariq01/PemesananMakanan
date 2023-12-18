using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedTableMakanan3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makanans",
                columns: new[] { "MakananId", "Harga", "MakananNama", "PicturePath" },
                values: new object[,]
                {
                    { 3, 3000f, "Telor Dadar", "/images/telorDadar.jpg" },
                    { 4, 5000f, "Kulit Ayam Goreng", "/images/KulitAyamGoreng.jpg" },
                    { 5, 12000f, "Nasgor Mentega", "/images/NasgorMentega.jpg" },
                    { 6, 15000f, "Omurice", "/images/OmuRice.jpg" },
                    { 7, 12000f, "Martabak Duren", "/images/MartabakDuren.jpg" },
                    { 8, 2000f, "Es Teh", "/images/EsTeh.jpg" },
                    { 9, 3000f, "Teh Tarik", "/images/telorCeplok.jpg" },
                    { 10, 5000f, "Josu", "/images/Josu.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 10);
        }
    }
}
