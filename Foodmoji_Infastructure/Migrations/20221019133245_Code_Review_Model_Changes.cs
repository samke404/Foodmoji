using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foodmoji_Infastructure.Migrations
{
    public partial class Code_Review_Model_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "RoleName");
        }
    }
}
