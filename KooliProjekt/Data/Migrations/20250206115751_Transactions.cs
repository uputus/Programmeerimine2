using Microsoft.EntityFrameworkCore.Migrations;

public partial class Transactions : Migration
{
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

        // Drop the AssetID column with IDENTITY property (temporarily)
        migrationBuilder.DropColumn(
            name: "AssetID",
            table: "Transactions");

        // Drop the TransactionID column with IDENTITY property (temporarily)
        migrationBuilder.DropColumn(
            name: "TransactionID",
            table: "Transactions");

        // Recreate AssetID column with IDENTITY
        migrationBuilder.AddColumn<int>(
            name: "AssetID",
            table: "Transactions",
            type: "int",
            nullable: false,
            defaultValue: 0)
            .Annotation("SqlServer:Identity", "1, 1");

        // Recreate TransactionID column without IDENTITY
        migrationBuilder.AddColumn<int>(
            name: "TransactionID",
            table: "Transactions",
            type: "int",
            nullable: false,
            defaultValue: 0);

        // Add new AssetID1 column
        migrationBuilder.AddColumn<int>(
            name: "AssetID1",
            table: "Transactions",
            type: "int",
            nullable: false,
            defaultValue: 0);

        // Add new ClassID column
        migrationBuilder.AddColumn<int>(
            name: "ClassID",
            table: "Transactions",
            type: "int",
            nullable: false,
            defaultValue: 0);

        // Add primary key back on AssetID
        migrationBuilder.AddPrimaryKey(
            name: "PK_Transactions",
            table: "Transactions",
            column: "AssetID");

        // Create index for AssetID1
        migrationBuilder.CreateIndex(
            name: "IX_Transactions_AssetID1",
            table: "Transactions",
            column: "AssetID1");

        // Add Foreign Key relationship for AssetID1
        migrationBuilder.AddForeignKey(
            name: "FK_Transactions_Assets_AssetID1",
            table: "Transactions",
            column: "AssetID1",
            principalTable: "Assets",
            principalColumn: "AssetID",
            onDelete: ReferentialAction.Cascade);
    }

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

        // Revert AssetID and TransactionID columns back to their previous state
        migrationBuilder.DropColumn(
            name: "AssetID",
            table: "Transactions");

        migrationBuilder.DropColumn(
            name: "TransactionID",
            table: "Transactions");

        // Recreate original AssetID column
        migrationBuilder.AddColumn<int>(
            name: "AssetID",
            table: "Transactions",
            type: "int",
            nullable: false,
            defaultValue: 0)
            .Annotation("SqlServer:Identity", "1, 1");

        // Recreate the original TransactionID column (without identity)
        migrationBuilder.AddColumn<int>(
            name: "TransactionID",
            table: "Transactions",
            type: "int",
            nullable: false,
            defaultValue: 0); // No identity here

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