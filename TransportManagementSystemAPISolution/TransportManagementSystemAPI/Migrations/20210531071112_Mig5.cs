using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class Mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Vehicles_VehicleNumber",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_VehicleNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_VehicleNumber",
                table: "Employees",
                column: "VehicleNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Vehicles_VehicleNumber",
                table: "Employees",
                column: "VehicleNumber",
                principalTable: "Vehicles",
                principalColumn: "VehicleNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
