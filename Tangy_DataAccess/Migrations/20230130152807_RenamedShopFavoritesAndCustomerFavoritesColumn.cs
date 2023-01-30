using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TangyDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamedShopFavoritesAndCustomerFavoritesColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopFavourites",
                table: "Products",
                newName: "ShopFavorites");

            migrationBuilder.RenameColumn(
                name: "CustomerFavourites",
                table: "Products",
                newName: "CustomerFavorites");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopFavorites",
                table: "Products",
                newName: "ShopFavourites");

            migrationBuilder.RenameColumn(
                name: "CustomerFavorites",
                table: "Products",
                newName: "CustomerFavourites");
        }
    }
}
