using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class ProductSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Urunler");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Urunler",
                newName: "UrunAdi");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Urunler",
                newName: "UrunNumarasi");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Urunler",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler",
                column: "UrunNumarasi");

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
            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler");

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunNumarasi",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunNumarasi",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunNumarasi",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Urunler");

            migrationBuilder.RenameTable(
                name: "Urunler",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "UrunAdi",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "UrunNumarasi",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");
        }
    }
}
