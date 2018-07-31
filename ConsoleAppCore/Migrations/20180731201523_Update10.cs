using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppCore.Migrations
{
    public partial class Update10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Becado",
                table: "Estudiante",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Carrera",
                table: "Estudiante",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaDePago",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Becado",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "Carrera",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "CategoriaDePago",
                table: "Estudiante");
        }
    }
}
