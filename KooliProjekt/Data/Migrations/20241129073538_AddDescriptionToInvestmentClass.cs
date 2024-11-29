using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToInvestmentClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "InvestmentClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "InvestmentClasses");
        }
    }
}
