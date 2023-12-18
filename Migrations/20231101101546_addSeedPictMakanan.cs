using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class addSeedPictMakanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Makanans",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 1,
                column: "PicturePath",
                value: "/images/indomie.jpg");

            migrationBuilder.UpdateData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 2,
                column: "PicturePath",
                value: "/images/telorCeplok.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Makanans");
        }
    }
}
