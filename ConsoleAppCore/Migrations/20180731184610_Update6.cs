using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppCore.Migrations
{
    public partial class Update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstitucionId",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Institucion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institucion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_InstitucionId",
                table: "Estudiante",
                column: "InstitucionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Institucion_InstitucionId",
                table: "Estudiante",
                column: "InstitucionId",
                principalTable: "Institucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Institucion_InstitucionId",
                table: "Estudiante");

            migrationBuilder.DropTable(
                name: "Institucion");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_InstitucionId",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "InstitucionId",
                table: "Estudiante");
        }
    }
}
