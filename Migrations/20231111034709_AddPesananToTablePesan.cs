using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PemesananMakanan.Migrations
{
    /// <inheritdoc />
    public partial class AddPesananToTablePesan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pesans_Pesanans_pesananId",
                table: "Pesans");

            migrationBuilder.RenameColumn(
                name: "pesananId",
                table: "Pesans",
                newName: "PesananId");

            migrationBuilder.RenameIndex(
                name: "IX_Pesans_pesananId",
                table: "Pesans",
                newName: "IX_Pesans_PesananId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pesans_Pesanans_PesananId",
                table: "Pesans",
                column: "PesananId",
                principalTable: "Pesanans",
                principalColumn: "pesananId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pesans_Pesanans_PesananId",
                table: "Pesans");

            migrationBuilder.RenameColumn(
                name: "PesananId",
                table: "Pesans",
                newName: "pesananId");

            migrationBuilder.RenameIndex(
                name: "IX_Pesans_PesananId",
                table: "Pesans",
                newName: "IX_Pesans_pesananId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pesans_Pesanans_pesananId",
                table: "Pesans",
                column: "pesananId",
                principalTable: "Pesanans",
                principalColumn: "pesananId");
        }
    }
}
