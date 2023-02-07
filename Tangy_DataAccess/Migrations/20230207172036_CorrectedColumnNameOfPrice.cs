using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TangyDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedColumnNameOfPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prize",
                table: "ProductPrices",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductPrices",
                newName: "Prize");
        }
    }
}
