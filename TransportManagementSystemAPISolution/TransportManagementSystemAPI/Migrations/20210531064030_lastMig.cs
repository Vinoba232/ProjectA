using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class lastMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Allocations",
                table: "Allocations");

            migrationBuilder.AddColumn<int>(
                name: "AllocationId",
                table: "Allocations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Allocations",
                table: "Allocations",
                column: "AllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_EmployeeId",
                table: "Allocations",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Allocations",
                table: "Allocations");

            migrationBuilder.DropIndex(
                name: "IX_Allocations_EmployeeId",
                table: "Allocations");

            migrationBuilder.DropColumn(
                name: "AllocationId",
                table: "Allocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Allocations",
                table: "Allocations",
                column: "EmployeeId");
        }
    }
}
