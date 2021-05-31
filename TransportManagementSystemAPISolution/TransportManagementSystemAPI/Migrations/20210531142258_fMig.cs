using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class fMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocations_Vehicles_VehicalNumber",
                table: "Allocations");

            migrationBuilder.DropIndex(
                name: "IX_Allocations_VehicalNumber",
                table: "Allocations");

            migrationBuilder.AlterColumn<string>(
                name: "VehicalNumber",
                table: "Allocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicalNumber",
                table: "Allocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_VehicalNumber",
                table: "Allocations",
                column: "VehicalNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Allocations_Vehicles_VehicalNumber",
                table: "Allocations",
                column: "VehicalNumber",
                principalTable: "Vehicles",
                principalColumn: "VehicleNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
