using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleAppCore
{
    class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-EditorTextos-20180727025531;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory().AddConsole((category,level)=> level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Entity<EstudianteCurso>().HasKey(x => new { x.CursoID, x.EstudianteId });

            modelBuilder.Entity<Estudiante>().HasOne(d => d.Detalles).WithOne(e => e.Estudiante)
                .HasForeignKey<EstudianteDetalle>(x => x.Id);
            modelBuilder.Entity<EstudianteDetalle>().ToTable("Estudiante");

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Institucion> Instituciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<EstudianteCurso> EstudiantesCursos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<TipoDocumentos> TipoDocumentos { get; set; }
        public virtual DbSet<CorreoElectronicos> CorreoElectronicos { get; set; }
        public virtual DbSet<TipoCorreos> TipoCorreos { get; set; }
        public virtual DbSet<Direcciones> Direcciones { get; set; }
        public virtual DbSet<PlantillaDocumentos> PlantillaDocumentos { get; set; }
        public virtual DbSet<ClientesDocumentoJuridicos> ClientesDocumentoJuridicos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
    }
}


