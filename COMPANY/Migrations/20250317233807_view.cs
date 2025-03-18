using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class view : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE VIEW EmployeeDepartmentView
        WITH ENCRYPTION
        AS
        SELECT 
            E.EmpId AS EmpId, 
            E.Name AS EmpName, 
            D.Dept_ID AS DepartmentId
        FROM 
            Employees E
        INNER JOIN 
            Departments D ON D.Dept_ID = E.DepartmentId
    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW EmployeeDepartmentView");


        }
    }
}
