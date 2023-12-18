using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class addQuantityMMakanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Makanans",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 1,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Makanans",
                keyColumn: "MakananId",
                keyValue: 2,
                column: "Quantity",
                value: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Makanans");
        }
    }
}
