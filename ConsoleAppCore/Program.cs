using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var _nombre = "Martin Olmedo Restrepo Carvajal";
            var _id = 1;
            var _edad = 20;

            using (var context = new ApplicationDbContext())
            {
                InsertEstudiantes(_nombre, _edad);
            }
            Console.WriteLine("Listo!");
        }


        static void InsertEstudiantes(string _nombre, int _edad)
        {
            using (var context = new ApplicationDbContext())
            {
                var estudiante = new Estudiante()
                {
                    Nombre = _nombre,
                    Edad = _edad
                };

                var direccion = new Direccion()
                {
                    Calle = "Calle Caracas"
                };

                estudiante.Direccion = direccion;
                BuscarEstudiantes("");
                context.Add(estudiante);
                context.SaveChanges();
            }
        }

        static void BuscarEstudiantes(string _nombre)
        {
            using (var context = new ApplicationDbContext())
            {
                if (_nombre == null)
                {
                    var estudiante = context.Estudiantes.Where(n => n.Nombre == _nombre).ToList();
                }
                else
                {
                    var estudiente = context.Estudiantes.Include(d => d.Direccion).ToList();
                }
            }
        }
    }

    [Table("Estudiante")]
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public virtual Direccion Direccion { get; set; }
        public int InstitucionId { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual EstudianteCurso GetEstudiantesCursos { get; set; }
        public virtual EstudianteDetalle Detalles { get; set; }
    }


    class EstudianteDetalle
    {
        public int Id { get; set; }
        public bool Becado { get; set; }
        public string Carrera { get; set; }
        public int CategoriaDePago { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }

    [Table("Direccion")]
    class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int EstudianteId { get; set; }
    }

    [Table("Institucion")]
    class Institucion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }

    [Table("Curso")]
    class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual EstudianteCurso GetEstudiantesCursos { get; set; }
}

    [Table("EstudianteCurso")]
    class EstudianteCurso
    {
        public int EstudianteId { get; set; }
        public int CursoID { get; set; }
        public bool Activo { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
