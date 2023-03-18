using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CardSingleEntityUpdatedParallelandCommentsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "CardSingles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parallel",
                table: "CardSingles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "CardSingles");

            migrationBuilder.DropColumn(
                name: "Parallel",
                table: "CardSingles");
        }
    }
}
