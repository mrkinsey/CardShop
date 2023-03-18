using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfitLosscardsinglecreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "CardSingles",
                newName: "QuantityPurchased");

            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "CardSingles",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "PurchasePrice",
                table: "CardSingles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QuantityAvailable",
                table: "CardSingles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SalePrice",
                table: "CardSingles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "CardSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CardSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comments",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "CardSingles");

            migrationBuilder.DropColumn(
                name: "QuantityAvailable",
                table: "CardSingles");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "CardSingles");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "CardSets");

            migrationBuilder.RenameColumn(
                name: "QuantityPurchased",
                table: "CardSingles",
                newName: "Quantity");

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "CardSingles",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
