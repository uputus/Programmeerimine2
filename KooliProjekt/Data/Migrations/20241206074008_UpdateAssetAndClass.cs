using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAssetAndClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetID",
                table: "InvestmentClasses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SelectedClassID",
                table: "InvestmentClasses",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetID",
                table: "InvestmentClasses");

            migrationBuilder.DropColumn(
                name: "SelectedClassID",
                table: "InvestmentClasses");
        }
    }
}
