using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE1.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Topic",
                newName: "Topic_ID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Student",
                newName: "Stud_ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructor",
                newName: "Inst_ID");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "Department",
                newName: "Inst_ID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Department",
                newName: "Dept_ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Course",
                newName: "Course_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CourseInst",
                columns: table => new
                {
                    Inst_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInst", x => x.Inst_ID);
                });

            migrationBuilder.CreateTable(
                name: "StudCourse",
                columns: table => new
                {
                    Stud_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudCourse", x => x.Stud_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInst");

            migrationBuilder.DropTable(
                name: "StudCourse");

            migrationBuilder.RenameColumn(
                name: "Topic_ID",
                table: "Topic",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Stud_ID",
                table: "Student",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Inst_ID",
                table: "Instructor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Inst_ID",
                table: "Department",
                newName: "Ins_ID");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Department",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "Course",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
