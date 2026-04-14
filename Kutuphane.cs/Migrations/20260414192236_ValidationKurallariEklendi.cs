using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane.Migrations
{
    /// <inheritdoc />
    public partial class ValidationKurallariEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yazar",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Stok",
                table: "Books",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "Fiyat",
                table: "Books",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Başlık",
                table: "Books",
                newName: "Author");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "Yazar");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Books",
                newName: "Stok");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Books",
                newName: "Fiyat");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "Başlık");
        }
    }
}
