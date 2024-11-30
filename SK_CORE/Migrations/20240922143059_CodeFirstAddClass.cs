using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SK_CORE.Migrations
{
    public partial class CodeFirstAddClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeEmailId",
                table: "Employees",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeEmailId",
                table: "Employees");
        }
    }
}
