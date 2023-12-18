using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class addSeedTableMakanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makanans",
                columns: new[] { "MakananId", "Harga", "MakananNama" },
                values: new object[] { 1, 5000f, "Indomie" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 1);
        }
    }
}
