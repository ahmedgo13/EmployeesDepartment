using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAndDepartment.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMany2ManyNavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentEmployee",
                columns: table => new
                {
                    DepartmentsDepartmentID = table.Column<int>(type: "int", nullable: false),
                    EmployeesEmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployee", x => new { x.DepartmentsDepartmentID, x.EmployeesEmployeeID });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Department_DepartmentsDepartmentID",
                        column: x => x.DepartmentsDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Employee_EmployeesEmployeeID",
                        column: x => x.EmployeesEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployee_EmployeesEmployeeID",
                table: "DepartmentEmployee",
                column: "EmployeesEmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentEmployee");
        }
    }
}
