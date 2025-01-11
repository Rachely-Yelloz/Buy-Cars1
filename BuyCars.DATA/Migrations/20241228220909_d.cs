using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyCars.DATA.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_castomers_castomerid",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "castomerid",
                table: "orders",
                newName: "Castomerid");

            migrationBuilder.RenameIndex(
                name: "IX_orders_castomerid",
                table: "orders",
                newName: "IX_orders_Castomerid");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_castomers_Castomerid",
                table: "orders",
                column: "Castomerid",
                principalTable: "castomers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_castomers_Castomerid",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "Castomerid",
                table: "orders",
                newName: "castomerid");

            migrationBuilder.RenameIndex(
                name: "IX_orders_Castomerid",
                table: "orders",
                newName: "IX_orders_castomerid");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_castomers_castomerid",
                table: "orders",
                column: "castomerid",
                principalTable: "castomers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
