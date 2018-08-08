using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace ConsoleAppCore
{
    class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K88TBLE;Initial Catalog=PruebaBd;Integrated Security=True")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory()
                .AddConsole((category,level)=> level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<EstudianteCurso>().HasKey(x => new { x.CursoID, x.EstudianteId});

            //modelBuilder.Entity<Estudiante>().HasOne(d => d.Detalles).WithOne(e => e.Estudiante)
            //    .HasForeignKey<EstudianteDetalle>(x => x.Id);

            //modelBuilder.Entity<EstudianteDetalle>().ToTable("Estudiante");


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //modelBuilder.Entity<AuxProductos>()
            //    .HasOne(a => a.TipoFlores)
            //    .WithMany(t => t.AuxProductos)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Productos>()
            //    .HasOne(p => p.TipoFlores)
            //    .WithMany(t => t.Productos)
            //    .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Clientes>().HasData(               
               new Clientes { Id = 1, PrimerNombre = "Antonio", SegundoNombre = "David", PrimerApellido = "Restrepo", SegundoApellido = "Carvajal", FechaNacimiento = new DateTime(1982, 12, 18), DireccionesId = 1 },
               new Clientes { Id = 2, PrimerNombre = "Martin", SegundoNombre = "Olmedo", PrimerApellido = "Gonzalez", SegundoApellido = "Perez", FechaNacimiento = new DateTime(1980, 02, 10), DireccionesId = 2 }
               );

            modelBuilder.Entity<Documentos>().HasData(
               new Documentos { Id = 1, TipoDocumentosId = 1, ClientesId = 1, FechaExpedicion = new DateTime(2010, 07, 1), LugarExpedicion = "Bogota", Nacionalidad = "Colombiano", NroDocumento = 1126905946 },
               new Documentos { Id = 2, TipoDocumentosId = 4, ClientesId = 2, FechaExpedicion = new DateTime(2017, 01, 31), LugarExpedicion = "Maturin", Nacionalidad = "Venezolano", NroDocumento = 876543290 }
               );

            modelBuilder.Entity<TipoDocumentos>().HasData(
               new TipoDocumentos { Id = 1, TipoDocumento = "CC", Descripcion = "cedula de ciudadania", Prioridad = 1 },
               new TipoDocumentos { Id = 2, TipoDocumento = "TI", Descripcion = "tarjeta de identidad", Prioridad = 2 },
               new TipoDocumentos { Id = 3, TipoDocumento = "CE", Descripcion = "cedula de extrajero", Prioridad = 3 },
               new TipoDocumentos { Id = 4, TipoDocumento = "PS", Descripcion = "pasaporte", Prioridad = 4 },
               new TipoDocumentos { Id = 5, TipoDocumento = "PEP", Descripcion = "permiso especial de permanencia", Prioridad = 5 }
               );

            modelBuilder.Entity<CorreoElectronicos>().HasData(
               new CorreoElectronicos { Id = 1, CorreoElectronico = "desarrollador@unicoc.edu.co", TipoCorreosId = 1, ClientesId = 1 },
               new CorreoElectronicos { Id = 2, CorreoElectronico = "viejotin@hotmail.com", TipoCorreosId = 2, ClientesId = 2 },
               new CorreoElectronicos { Id = 3, CorreoElectronico = "ford@ford.co", TipoCorreosId = 1 },
               new CorreoElectronicos { Id = 4, CorreoElectronico = "unicoc@unicoc.edu.co", TipoCorreosId = 1 }
               );

            modelBuilder.Entity<TipoCorreos>().HasData(
               new TipoCorreos { Id = 1, TipoCorreo = "Correo institucional" },
               new TipoCorreos { Id = 2, TipoCorreo = "Correo personal" },
               new TipoCorreos { Id = 3, TipoCorreo = "Correo secundario" }
               );

            modelBuilder.Entity<Direcciones>().HasData(
               new Direcciones { Id = 1, Ciudad = "Bogota", Departamento = "Cundinamarca", Direccion = "Carrera 3 #10-00, Apto. 404", Pais = "Colombia", CodeZip = "2006-1" },
               new Direcciones { Id = 2, Ciudad = "Valledupar", Departamento = "Cesar", Direccion = "Calle 27 #16-20", Pais = "Colombia", CodeZip = "2910-0" }
               );

            modelBuilder.Entity<PlantillaDocumentos>().HasData(
               new PlantillaDocumentos { Id = 1, Plantilla = "Plantilla prueba 1", Descipcion = "Plantilla de prueba", DocumentoTexto = "<p>Prueba nro 1</p>", FechaCreacion = new DateTime(2018, 01, 01), FechaActualizacion = new DateTime(2018, 01, 01) },
               new PlantillaDocumentos { Id = 2, Plantilla = "Plantilla prueba 2", Descipcion = "Plantilla de prueba", DocumentoTexto = "<p>Prueba nro 2</p>", FechaCreacion = new DateTime(2018, 01, 01), FechaActualizacion = new DateTime(2018, 01, 01) }
               );

            modelBuilder.Entity<Empresas>().HasData(
               new Empresas { Id = 1, Empresa = "FORD", CorreoElectronicosId = 3, DireccionesId = 1 },
               new Empresas { Id = 2, Empresa = "UNICOC", CorreoElectronicosId = 4, DireccionesId = 2 }
               );


        }

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


