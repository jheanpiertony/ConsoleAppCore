﻿// <auto-generated />
using ConsoleAppCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleAppCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180731193824_Update9")]
    partial class Update9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleAppCore.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ConsoleAppCore.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle");

                    b.Property<int>("EstudianteId");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId")
                        .IsUnique();

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("ConsoleAppCore.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Edad");

                    b.Property<int>("InstitucionId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("InstitucionId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("ConsoleAppCore.EstudianteCurso", b =>
                {
                    b.Property<int>("CursoID");

                    b.Property<int>("EstudianteId");

                    b.Property<bool>("Activo");

                    b.HasKey("CursoID", "EstudianteId");

                    b.HasIndex("CursoID")
                        .IsUnique();

                    b.HasIndex("EstudianteId")
                        .IsUnique();

                    b.ToTable("EstudianteCurso");
                });

            modelBuilder.Entity("ConsoleAppCore.Institucion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Institucion");
                });

            modelBuilder.Entity("ConsoleAppCore.Direccion", b =>
                {
                    b.HasOne("ConsoleAppCore.Estudiante")
                        .WithOne("Direccion")
                        .HasForeignKey("ConsoleAppCore.Direccion", "EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleAppCore.Estudiante", b =>
                {
                    b.HasOne("ConsoleAppCore.Institucion", "Institucion")
                        .WithMany("Estudiantes")
                        .HasForeignKey("InstitucionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleAppCore.EstudianteCurso", b =>
                {
                    b.HasOne("ConsoleAppCore.Curso", "Curso")
                        .WithOne("GetEstudiantesCursos")
                        .HasForeignKey("ConsoleAppCore.EstudianteCurso", "CursoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleAppCore.Estudiante", "Estudiante")
                        .WithOne("GetEstudiantesCursos")
                        .HasForeignKey("ConsoleAppCore.EstudianteCurso", "EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
