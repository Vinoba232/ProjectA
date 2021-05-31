using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class nullMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocations_Vehicles_VehicalNumber",
                table: "Allocations");

            migrationBuilder.AlterColumn<string>(
                name: "VehicalNumber",
                table: "Allocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Allocations_Vehicles_VehicalNumber",
                table: "Allocations",
                column: "VehicalNumber",
                principalTable: "Vehicles",
                principalColumn: "VehicleNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocations_Vehicles_VehicalNumber",
                table: "Allocations");

            migrationBuilder.AlterColumn<string>(
                name: "VehicalNumber",
                table: "Allocations",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
