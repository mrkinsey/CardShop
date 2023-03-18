using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class QuantityandValueAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CardSingles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "CardSingles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CardSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "CardSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CardSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Quantity", "Value" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CardSingles");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CardSingles");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CardSets");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CardSets");
        }
    }
}
