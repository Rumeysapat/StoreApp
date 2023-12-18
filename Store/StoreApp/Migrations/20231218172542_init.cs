using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunNumarasi = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: true),
                    Fiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunNumarasi);
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunNumarasi", "Aciklama", "Fiyat", "UrunAdi" },
                values: new object[] { 1, "Bu ürünün açıklaması 1", 49.99m, "Ürün 1" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunNumarasi", "Aciklama", "Fiyat", "UrunAdi" },
                values: new object[] { 2, "Bu ürünün açıklaması 2", 29.99m, "Ürün 2" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunNumarasi", "Aciklama", "Fiyat", "UrunAdi" },
                values: new object[] { 3, "Bu ürünün açıklaması 3", 39.99m, "Ürün 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
