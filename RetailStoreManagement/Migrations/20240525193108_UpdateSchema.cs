using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailStoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "PurchaseProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProducts_ProductId1",
                table: "PurchaseProducts",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseProducts_Products_ProductId1",
                table: "PurchaseProducts",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseProducts_Products_ProductId1",
                table: "PurchaseProducts");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseProducts_ProductId1",
                table: "PurchaseProducts");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "PurchaseProducts");
        }
    }
}
