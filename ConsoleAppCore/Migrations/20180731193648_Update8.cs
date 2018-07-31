using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppCore.Migrations
{
    public partial class Update8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudiantesCursos_Curso_CursoID",
                table: "EstudiantesCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiantesCursos_Estudiante_EstudianteId",
                table: "EstudiantesCursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstudiantesCursos",
                table: "EstudiantesCursos");

            migrationBuilder.DropIndex(
                name: "IX_EstudiantesCursos_EstudianteId",
                table: "EstudiantesCursos");

            migrationBuilder.RenameTable(
                name: "EstudiantesCursos",
                newName: "EstudianteCurso");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstudianteCurso",
                table: "EstudianteCurso",
                columns: new[] { "CursoID", "EstudianteId" });

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteCurso_CursoID",
                table: "EstudianteCurso",
                column: "CursoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteCurso_EstudianteId",
                table: "EstudianteCurso",
                column: "EstudianteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudianteCurso_Curso_CursoID",
                table: "EstudianteCurso",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudianteCurso_Estudiante_EstudianteId",
                table: "EstudianteCurso",
                column: "EstudianteId",
                principalTable: "Estudiante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudianteCurso_Curso_CursoID",
                table: "EstudianteCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudianteCurso_Estudiante_EstudianteId",
                table: "EstudianteCurso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstudianteCurso",
                table: "EstudianteCurso");

            migrationBuilder.DropIndex(
                name: "IX_EstudianteCurso_CursoID",
                table: "EstudianteCurso");

            migrationBuilder.DropIndex(
                name: "IX_EstudianteCurso_EstudianteId",
                table: "EstudianteCurso");

            migrationBuilder.RenameTable(
                name: "EstudianteCurso",
                newName: "EstudiantesCursos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstudiantesCursos",
                table: "EstudiantesCursos",
                columns: new[] { "CursoID", "EstudianteId" });

            migrationBuilder.CreateIndex(
                name: "IX_EstudiantesCursos_EstudianteId",
                table: "EstudiantesCursos",
                column: "EstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiantesCursos_Curso_CursoID",
                table: "EstudiantesCursos",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiantesCursos_Estudiante_EstudianteId",
                table: "EstudiantesCursos",
                column: "EstudianteId",
                principalTable: "Estudiante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
