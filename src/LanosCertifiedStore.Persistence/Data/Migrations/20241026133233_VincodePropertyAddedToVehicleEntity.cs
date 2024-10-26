using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanosCertifiedStore.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class VincodePropertyAddedToVehicleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vincode",
                schema: "vehicles",
                table: "Vehicles",
                type: "character varying(17)",
                maxLength: 17,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Vincode",
                schema: "vehicles",
                table: "Vehicles",
                column: "Vincode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicles_Vincode",
                schema: "vehicles",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Vincode",
                schema: "vehicles",
                table: "Vehicles");
        }
    }
}
