using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCardSet_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardSets",
                columns: new[] { "Id", "BrandName", "CategoryId", "SetName", "Year" },
                values: new object[] { 1, "Topps", 3, "Series 1", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardSets",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
