using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystemAPI.Migrations
{
    public partial class allocateMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicalNumber",
                table: "Allocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicalNumber",
                table: "Allocations");
        }
    }
}
