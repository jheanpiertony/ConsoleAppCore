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
    [Migration("20180731181553_Update5")]
    partial class Update5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("ConsoleAppCore.Direccion", b =>
                {
                    b.HasOne("ConsoleAppCore.Estudiante")
                        .WithOne("Direccion")
                        .HasForeignKey("ConsoleAppCore.Direccion", "EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
