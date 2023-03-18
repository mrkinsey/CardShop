using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfitLosscardsetcreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "CardSets",
                newName: "QuantityPurchased");

            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "CardSets",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "PurchasePrice",
                table: "CardSets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QuantityAvailable",
                table: "CardSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SalePrice",
                table: "CardSets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "CardSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PurchasePrice", "QuantityAvailable", "SalePrice", "Value" },
                values: new object[] { 0.0, 0, 0.0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "CardSets");

            migrationBuilder.DropColumn(
                name: "QuantityAvailable",
                table: "CardSets");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "CardSets");

            migrationBuilder.RenameColumn(
                name: "QuantityPurchased",
                table: "CardSets",
                newName: "Quantity");

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "CardSets",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "CardSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Value",
                value: 0);
        }
    }
}
