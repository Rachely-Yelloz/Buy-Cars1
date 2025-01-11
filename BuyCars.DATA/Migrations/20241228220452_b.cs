using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyCars.DATA.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_cars_carId",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "carId",
                table: "orders",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_carId",
                table: "orders",
                newName: "IX_orders_CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_cars_CarId",
                table: "orders",
                column: "CarId",
                principalTable: "cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_cars_CarId",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "orders",
                newName: "carId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_CarId",
                table: "orders",
                newName: "IX_orders_carId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_cars_carId",
                table: "orders",
                column: "carId",
                principalTable: "cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
