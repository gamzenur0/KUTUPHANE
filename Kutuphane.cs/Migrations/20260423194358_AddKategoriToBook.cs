using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane.Migrations
{
    /// <inheritdoc />
    public partial class AddKategoriToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_KategoriId",
                table: "Books",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Kategoriler_KategoriId",
                table: "Books",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Kategoriler_KategoriId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Books_KategoriId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Books");
        }
    }
}
