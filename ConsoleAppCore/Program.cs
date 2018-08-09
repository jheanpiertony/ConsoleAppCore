using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            using (var context = new ApplicationDbContext())
            {
                var consulta = context.Clientes
                    .Include(dc => dc.Documentos)
                    .ThenInclude(tp => tp.TipoDocumentos).FirstOrDefault();

                Console.WriteLine("Listo!");
                Console.ReadLine();
            }
        }


        //static void InsertEstudiantes(string _nombre, string _apellido)
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        var estudiante = new Estudiante()
        //        {
        //            PrimerNombre = _nombre,
        //            PrimerApellido = _apellido
        //        };

        //        var direccion = new Direccion()
        //        {
        //            Calle = "Calle Caracas"
        //        };

        //        estudiante.Direccion = direccion;
        //        BuscarEstudiantes("");
        //        context.Add(estudiante);
        //        context.SaveChanges();
        //    }
        //}

        //static void BuscarEstudiantes(string _nombre)
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        if (_nombre == null)
        //        {
        //            var estudiante = context.Estudiantes.Where(n => n.PrimerNombre == _nombre).ToList();
        //        }
        //        else
        //        {
        //            var estudiente = context.Estudiantes.Include(d => d.Direccion).ToList();
        //        }
        //    }
        //}
    //}

    //[Table("Estudiante")]
    //public class Estudiante: Entidad
    //{
    //    public String PrimerNombre { get; set; }
    //    public String SegundoNombre { get; set; }
    //    public String PrimerApellido { get; set; }
    //    public String SegundoApellido { get; set; }
    //    [DataType(DataType.Date)]
    //    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    //    public DateTime FechaNacimiento { get; set; }

    //    public virtual Direccion Direccion { get; set; }
    //    //public int InstitucionId { get; set; }
    //    //public virtual Institucion Institucion { get; set; }
    //    //public virtual EstudianteCurso GetEstudiantesCursos { get; set; }
    //    //public virtual EstudianteDetalle Detalles { get; set; }
    //    public virtual ICollection<Documentos> Documentos { get; set; }
    }

    //[Table("EstudianteDetalle")]
    //public class EstudianteDetalle
    //{
    //    public int Id { get; set; }
    //    public bool Becado { get; set; }
    //    public string Carrera { get; set; }
    //    public int CategoriaDePago { get; set; }
    //    public virtual Estudiante Estudiante { get; set; }
    //}

    //    [Table("Direccion")]
    //    public class Direccion
    //    {
    //        public int Id { get; set; }
    //        public string Calle { get; set; }
    //        //public int EstudianteId { get; set; }
    //    }

    //    [Table("Institucion")]
    //    public class Institucion
    //    {
    //        public int Id { get; set; }
    //        public string Nombre { get; set; }
    //        //public List<Estudiante> Estudiantes { get; set; }
    //    }

    //    [Table("Curso")]
    //    public class Curso
    //    {
    //        public int Id { get; set; }
    //        public string Nombre { get; set; }
    //        public virtual EstudianteCurso GetEstudiantesCursos { get; set; }
    //}

    //    [Table("EstudianteCurso")]
    //    public class EstudianteCurso
    //    {
    //        public int EstudianteId { get; set; }
    //        public int CursoID { get; set; }
    //        public bool Activo { get; set; }
    //        //public virtual Estudiante Estudiante { get; set; }
    //        public virtual Curso Curso { get; set; }
    //    }

    //    [Table("Documentos")]
    //    public class Documentos : Entidad
    //    {
    //        public Int64 NroDocumento { get; set; }
    //        public string Nacionalidad { get; set; }
    //        [DataType(DataType.Date)]
    //        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    //        public DateTime FechaExpedicion { get; set; }
    //        public string LugarExpedicion { get; set; }

    //        public int EstudianteId { get; set; }
    //        public virtual Estudiante Estudiantes { get; set; }
    //        public int TipoDocumentosId { get; set; }
    //        public virtual TipoDocumentos TipoDocumentos { get; set; }
    //    }

    //    [Table("TipoDocumentos")]
    //    public class TipoDocumentos : Entidad
    //    {
    //        public string TipoDocumento { get; set; }
    //        public string Descripcion { get; set; }
    //        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //        public int Prioridad { get; set; }
    //    }

    //    public class Entidad
    //    {
    //        [Key]
    //        public int Id { get; set; }
    //    }
}
