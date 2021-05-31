using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class secongMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allocations",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RouteNumber = table.Column<int>(type: "int", nullable: true),
                    VehicalNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allocations", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Allocations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Allocations_Routes_RouteNumber",
                        column: x => x.RouteNumber,
                        principalTable: "Routes",
                        principalColumn: "RouteNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Allocations_Vehicles_VehicalNumber",
                        column: x => x.VehicalNumber,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_RouteNumber",
                table: "Allocations",
                column: "RouteNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_VehicalNumber",
                table: "Allocations",
                column: "VehicalNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allocations");
        }
    }
}
