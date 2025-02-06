using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    /// <inheritdoc />
    public partial class Transactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Assets_AssetID",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AssetID",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "AssetID",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionID",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AssetID1",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AssetID1",
                table: "Transactions",
                column: "AssetID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Assets_AssetID1",
                table: "Transactions",
                column: "AssetID1",
                principalTable: "Assets",
                principalColumn: "AssetID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Assets_AssetID1",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AssetID1",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AssetID1",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionID",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AssetID",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AssetID",
                table: "Transactions",
                column: "AssetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Assets_AssetID",
                table: "Transactions",
                column: "AssetID",
                principalTable: "Assets",
                principalColumn: "AssetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
