﻿// <auto-generated />
using System;
using ConsoleAppCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleAppCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleAppCore.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DireccionesId");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("PrimerApellido");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoApellido");

                    b.Property<string>("SegundoNombre");

                    b.HasKey("Id");

                    b.HasIndex("DireccionesId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new { Id = 1, DireccionesId = 1, FechaNacimiento = new DateTime(1982, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), PrimerApellido = "Restrepo", PrimerNombre = "Antonio", SegundoApellido = "Carvajal", SegundoNombre = "David" },
                        new { Id = 2, DireccionesId = 2, FechaNacimiento = new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), PrimerApellido = "Gonzalez", PrimerNombre = "Martin", SegundoApellido = "Perez", SegundoNombre = "Olmedo" }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.ClientesDocumentoJuridicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientesId");

                    b.Property<string>("DocumentoTexto");

                    b.Property<int>("EmpresasId");

                    b.Property<DateTime?>("FechaActualizacion");

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<int>("PlantillaDocumentosId");

                    b.Property<string>("Resumen");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("EmpresasId");

                    b.HasIndex("PlantillaDocumentosId");

                    b.ToTable("ClientesDocumentoJuridicos");
                });

            modelBuilder.Entity("ConsoleAppCore.CorreoElectronicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientesId");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired();

                    b.Property<int>("TipoCorreosId");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("TipoCorreosId");

                    b.ToTable("CorreoElectronicos");

                    b.HasData(
                        new { Id = 1, ClientesId = 1, CorreoElectronico = "desarrollador@unicoc.edu.co", TipoCorreosId = 1 },
                        new { Id = 2, ClientesId = 2, CorreoElectronico = "viejotin@hotmail.com", TipoCorreosId = 2 },
                        new { Id = 3, CorreoElectronico = "ford@ford.co", TipoCorreosId = 1 },
                        new { Id = 4, CorreoElectronico = "unicoc@unicoc.edu.co", TipoCorreosId = 1 }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.Direcciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad");

                    b.Property<string>("CodeZip");

                    b.Property<string>("Departamento");

                    b.Property<string>("Direccion");

                    b.Property<string>("Pais");

                    b.HasKey("Id");

                    b.ToTable("Direcciones");

                    b.HasData(
                        new { Id = 1, Ciudad = "Bogota", CodeZip = "2006-1", Departamento = "Cundinamarca", Direccion = "Carrera 3 #10-00, Apto. 404", Pais = "Colombia" },
                        new { Id = 2, Ciudad = "Valledupar", CodeZip = "2910-0", Departamento = "Cesar", Direccion = "Calle 27 #16-20", Pais = "Colombia" }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.Documentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientesId");

                    b.Property<DateTime>("FechaExpedicion");

                    b.Property<string>("LugarExpedicion");

                    b.Property<string>("Nacionalidad");

                    b.Property<long>("NroDocumento");

                    b.Property<int>("TipoDocumentosId");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("TipoDocumentosId");

                    b.ToTable("Documentos");

                    b.HasData(
                        new { Id = 1, ClientesId = 1, FechaExpedicion = new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LugarExpedicion = "Bogota", Nacionalidad = "Colombiano", NroDocumento = 1126905946L, TipoDocumentosId = 1 },
                        new { Id = 2, ClientesId = 2, FechaExpedicion = new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), LugarExpedicion = "Maturin", Nacionalidad = "Venezolano", NroDocumento = 876543290L, TipoDocumentosId = 4 }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.Empresas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorreoElectronicosId");

                    b.Property<int>("DireccionesId");

                    b.Property<string>("Empresa");

                    b.HasKey("Id");

                    b.HasIndex("CorreoElectronicosId");

                    b.HasIndex("DireccionesId");

                    b.ToTable("Empresas");

                    b.HasData(
                        new { Id = 1, CorreoElectronicosId = 3, DireccionesId = 1, Empresa = "FORD" },
                        new { Id = 2, CorreoElectronicosId = 4, DireccionesId = 2, Empresa = "UNICOC" }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.PlantillaDocumentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descipcion");

                    b.Property<string>("DocumentoTexto");

                    b.Property<DateTime?>("FechaActualizacion");

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<string>("Plantilla");

                    b.HasKey("Id");

                    b.ToTable("PlantillaDocumentos");

                    b.HasData(
                        new { Id = 1, Descipcion = "Plantilla de prueba", DocumentoTexto = "<p>Prueba nro 1</p>", FechaActualizacion = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FechaCreacion = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Plantilla = "Plantilla prueba 1" },
                        new { Id = 2, Descipcion = "Plantilla de prueba", DocumentoTexto = "<p>Prueba nro 2</p>", FechaActualizacion = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FechaCreacion = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Plantilla = "Plantilla prueba 2" }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.TipoCorreos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoCorreo");

                    b.HasKey("Id");

                    b.ToTable("TipoCorreos");

                    b.HasData(
                        new { Id = 1, TipoCorreo = "Correo institucional" },
                        new { Id = 2, TipoCorreo = "Correo personal" },
                        new { Id = 3, TipoCorreo = "Correo secundario" }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.TipoDocumentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("Prioridad");

                    b.Property<string>("TipoDocumento");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentos");

                    b.HasData(
                        new { Id = 1, Descripcion = "cedula de ciudadania", Prioridad = 1, TipoDocumento = "CC" },
                        new { Id = 2, Descripcion = "tarjeta de identidad", Prioridad = 2, TipoDocumento = "TI" },
                        new { Id = 3, Descripcion = "cedula de extrajero", Prioridad = 3, TipoDocumento = "CE" },
                        new { Id = 4, Descripcion = "pasaporte", Prioridad = 4, TipoDocumento = "PS" },
                        new { Id = 5, Descripcion = "permiso especial de permanencia", Prioridad = 5, TipoDocumento = "PEP" }
                    );
                });

            modelBuilder.Entity("ConsoleAppCore.Clientes", b =>
                {
                    b.HasOne("ConsoleAppCore.Direcciones", "Direcciones")
                        .WithMany()
                        .HasForeignKey("DireccionesId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ConsoleAppCore.ClientesDocumentoJuridicos", b =>
                {
                    b.HasOne("ConsoleAppCore.Clientes", "Clientes")
                        .WithMany("ClientesDocumentoJuridicos")
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ConsoleAppCore.Empresas", "Empresas")
                        .WithMany("ClientesDocumentoJuridicos")
                        .HasForeignKey("EmpresasId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ConsoleAppCore.PlantillaDocumentos", "PlantillaDocumentos")
                        .WithMany("ClientesDocumentoJuridicos")
                        .HasForeignKey("PlantillaDocumentosId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ConsoleAppCore.CorreoElectronicos", b =>
                {
                    b.HasOne("ConsoleAppCore.Clientes", "Clientes")
                        .WithMany("CorreoElectronicos")
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ConsoleAppCore.TipoCorreos", "TipoCorreos")
                        .WithMany()
                        .HasForeignKey("TipoCorreosId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ConsoleAppCore.Documentos", b =>
                {
                    b.HasOne("ConsoleAppCore.Clientes", "Clientes")
                        .WithMany("Documentos")
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ConsoleAppCore.TipoDocumentos", "TipoDocumentos")
                        .WithMany()
                        .HasForeignKey("TipoDocumentosId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ConsoleAppCore.Empresas", b =>
                {
                    b.HasOne("ConsoleAppCore.CorreoElectronicos", "CorreoElectronicos")
                        .WithMany()
                        .HasForeignKey("CorreoElectronicosId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ConsoleAppCore.Direcciones", "Direcciones")
                        .WithMany()
                        .HasForeignKey("DireccionesId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
