using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppCore.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Estudiantes",
                table: "Estudiantes");

            migrationBuilder.RenameTable(
                name: "Estudiantes",
                newName: "Estudiante");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estudiante",
                table: "Estudiante",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Estudiante",
                table: "Estudiante");

            migrationBuilder.RenameTable(
                name: "Estudiante",
                newName: "Estudiantes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estudiantes",
                table: "Estudiantes",
                column: "Id");
        }
    }
}
