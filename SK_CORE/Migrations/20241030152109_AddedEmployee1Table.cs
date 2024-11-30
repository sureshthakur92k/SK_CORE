using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SK_CORE.Migrations
{
    public partial class AddedEmployee1Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    EmployeeGender = table.Column<string>(type: "varchar(20)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    EmployeeSalary = table.Column<int>(type: "Int", nullable: false),
                    EmployeeEmailId = table.Column<string>(type: "varchar(100)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees1");
        }
    }
}
