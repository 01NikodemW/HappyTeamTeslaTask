using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeslaRentalBackend.Migrations
{
    /// <inheritdoc />
    public partial class addtotalpricetoreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RentalPricePerDay",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RentalLocationId",
                table: "Reservations",
                column: "RentalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReturnLocationId",
                table: "Reservations",
                column: "ReturnLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_RentalLocationId",
                table: "Reservations",
                column: "RentalLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_ReturnLocationId",
                table: "Reservations",
                column: "ReturnLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Vehicles_VehicleId",
                table: "Reservations",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_RentalLocationId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_ReturnLocationId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Vehicles_VehicleId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RentalLocationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReturnLocationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Reservations");

            migrationBuilder.AlterColumn<float>(
                name: "RentalPricePerDay",
                table: "Vehicles",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
