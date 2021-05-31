using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class plsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicalNumber",
                table: "Allocations");

            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "Allocations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_VehicleNumber",
                table: "Allocations",
                column: "VehicleNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Allocations_Vehicles_VehicleNumber",
                table: "Allocations",
                column: "VehicleNumber",
                principalTable: "Vehicles",
                principalColumn: "VehicleNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocations_Vehicles_VehicleNumber",
                table: "Allocations");

            migrationBuilder.DropIndex(
                name: "IX_Allocations_VehicleNumber",
                table: "Allocations");

            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "Allocations");

            migrationBuilder.AddColumn<string>(
                name: "VehicalNumber",
                table: "Allocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
