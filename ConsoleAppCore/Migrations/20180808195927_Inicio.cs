using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppCore.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pais = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    CodeZip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantillaDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    Plantilla = table.Column<string>(nullable: true),
                    Descipcion = table.Column<string>(nullable: true),
                    DocumentoTexto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantillaDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCorreos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoCorreo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCorreos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDocumento = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Prioridad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimerNombre = table.Column<string>(nullable: true),
                    SegundoNombre = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: true),
                    SegundoApellido = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    DireccionesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Direcciones_DireccionesId",
                        column: x => x.DireccionesId,
                        principalTable: "Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CorreoElectronicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CorreoElectronico = table.Column<string>(nullable: false),
                    ClientesId = table.Column<int>(nullable: true),
                    TipoCorreosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorreoElectronicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorreoElectronicos_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CorreoElectronicos_TipoCorreos_TipoCorreosId",
                        column: x => x.TipoCorreosId,
                        principalTable: "TipoCorreos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NroDocumento = table.Column<long>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: true),
                    FechaExpedicion = table.Column<DateTime>(nullable: false),
                    LugarExpedicion = table.Column<string>(nullable: true),
                    ClientesId = table.Column<int>(nullable: false),
                    TipoDocumentosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_TipoDocumentos_TipoDocumentosId",
                        column: x => x.TipoDocumentosId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Empresa = table.Column<string>(nullable: true),
                    DireccionesId = table.Column<int>(nullable: false),
                    CorreoElectronicosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_CorreoElectronicos_CorreoElectronicosId",
                        column: x => x.CorreoElectronicosId,
                        principalTable: "CorreoElectronicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_Direcciones_DireccionesId",
                        column: x => x.DireccionesId,
                        principalTable: "Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientesDocumentoJuridicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    DocumentoTexto = table.Column<string>(nullable: true),
                    Resumen = table.Column<string>(nullable: true),
                    ClientesId = table.Column<int>(nullable: false),
                    PlantillaDocumentosId = table.Column<int>(nullable: false),
                    EmpresasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesDocumentoJuridicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientesDocumentoJuridicos_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientesDocumentoJuridicos_Empresas_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientesDocumentoJuridicos_PlantillaDocumentos_PlantillaDocumentosId",
                        column: x => x.PlantillaDocumentosId,
                        principalTable: "PlantillaDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Direcciones",
                columns: new[] { "Id", "Ciudad", "CodeZip", "Departamento", "Direccion", "Pais" },
                values: new object[,]
                {
                    { 1, "Bogota", "2006-1", "Cundinamarca", "Carrera 3 #10-00, Apto. 404", "Colombia" },
                    { 2, "Valledupar", "2910-0", "Cesar", "Calle 27 #16-20", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "PlantillaDocumentos",
                columns: new[] { "Id", "Descipcion", "DocumentoTexto", "FechaActualizacion", "FechaCreacion", "Plantilla" },
                values: new object[,]
                {
                    { 1, "Plantilla de prueba", "<p>Prueba nro 1</p>", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plantilla prueba 1" },
                    { 2, "Plantilla de prueba", "<p>Prueba nro 2</p>", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plantilla prueba 2" }
                });

            migrationBuilder.InsertData(
                table: "TipoCorreos",
                columns: new[] { "Id", "TipoCorreo" },
                values: new object[,]
                {
                    { 1, "Correo institucional" },
                    { 2, "Correo personal" },
                    { 3, "Correo secundario" }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "Descripcion", "Prioridad", "TipoDocumento" },
                values: new object[,]
                {
                    { 1, "cedula de ciudadania", 1, "CC" },
                    { 2, "tarjeta de identidad", 2, "TI" },
                    { 3, "cedula de extrajero", 3, "CE" },
                    { 4, "pasaporte", 4, "PS" },
                    { 5, "permiso especial de permanencia", 5, "PEP" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "DireccionesId", "FechaNacimiento", "PrimerApellido", "PrimerNombre", "SegundoApellido", "SegundoNombre" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1982, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Restrepo", "Antonio", "Carvajal", "David" },
                    { 2, 2, new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gonzalez", "Martin", "Perez", "Olmedo" }
                });

            migrationBuilder.InsertData(
                table: "CorreoElectronicos",
                columns: new[] { "Id", "ClientesId", "CorreoElectronico", "TipoCorreosId" },
                values: new object[,]
                {
                    { 3, null, "ford@ford.co", 1 },
                    { 4, null, "unicoc@unicoc.edu.co", 1 }
                });

            migrationBuilder.InsertData(
                table: "CorreoElectronicos",
                columns: new[] { "Id", "ClientesId", "CorreoElectronico", "TipoCorreosId" },
                values: new object[,]
                {
                    { 1, 1, "desarrollador@unicoc.edu.co", 1 },
                    { 2, 2, "viejotin@hotmail.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "Documentos",
                columns: new[] { "Id", "ClientesId", "FechaExpedicion", "LugarExpedicion", "Nacionalidad", "NroDocumento", "TipoDocumentosId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bogota", "Colombiano", 1126905946L, 1 },
                    { 2, 2, new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maturin", "Venezolano", 876543290L, 4 }
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "CorreoElectronicosId", "DireccionesId", "Empresa" },
                values: new object[,]
                {
                    { 1, 3, 1, "FORD" },
                    { 2, 4, 2, "UNICOC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DireccionesId",
                table: "Clientes",
                column: "DireccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesDocumentoJuridicos_ClientesId",
                table: "ClientesDocumentoJuridicos",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesDocumentoJuridicos_EmpresasId",
                table: "ClientesDocumentoJuridicos",
                column: "EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesDocumentoJuridicos_PlantillaDocumentosId",
                table: "ClientesDocumentoJuridicos",
                column: "PlantillaDocumentosId");

            migrationBuilder.CreateIndex(
                name: "IX_CorreoElectronicos_ClientesId",
                table: "CorreoElectronicos",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_CorreoElectronicos_TipoCorreosId",
                table: "CorreoElectronicos",
                column: "TipoCorreosId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_ClientesId",
                table: "Documentos",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_TipoDocumentosId",
                table: "Documentos",
                column: "TipoDocumentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_CorreoElectronicosId",
                table: "Empresas",
                column: "CorreoElectronicosId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_DireccionesId",
                table: "Empresas",
                column: "DireccionesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesDocumentoJuridicos");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "PlantillaDocumentos");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");

            migrationBuilder.DropTable(
                name: "CorreoElectronicos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TipoCorreos");

            migrationBuilder.DropTable(
                name: "Direcciones");
        }
    }
}
