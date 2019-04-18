namespace ConsoleAppCore
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine(Singleton.Instance.mensaje);
            //Singleton.Instance.mensaje = "q dice si va!!";
            //Console.WriteLine(Singleton.Instance.mensaje);









            //List<class1> list = new List<class1>
            //{
            //    new class1 { Prop1="antonio", Prop2= "", Prop3 = "32"},
            //    new class1 { Prop1="luciana", Prop2= "gonzalez", Prop3= "23" }
            //};


            //string[,] arreglo = new string[3, 3];



            //foreach (var item in list)
            //{
            //    foreach (var item2 in item.Valor())
            //    {
            //        var a = item2.ToString();
            //    }
            //}
            //Console.Write();
            //Creating Class Object
            //class1 objClass1 = new class1 { prop1 = "value1", prop2 = "value2" };

            ////Passing Class Object to GenericPropertyFinder Class
            //GenericPropertyFinder<class1> objGenericPropertyFinder = new GenericPropertyFinder<class1>();
            //objGenericPropertyFinder.PrintTModelPropertyAndValue(objClass1);

            Console.ReadLine();
            // aca en pc personal


            


            //using (var context = new ApplicationDbContext())
            //{
            //    var consulta = context.Clientes
            //        .Include(dc => dc.Documentos)
            //        .ThenInclude(tp => tp.TipoDocumentos).FirstOrDefault();

            //    Console.WriteLine("Listo!");
            //    Console.ReadLine();
            //}
        }




        


        //Declaring a Sample Class 
        public class class1
        {
            public string Prop1 { get; set; }
            public string Prop2 { get; set; }
            public string Prop3 { get; set; }
            public string[] Valor()
            {
                int i = 0;
                string[] a= new string[3];
                a[i++] = Prop1.ToString();
                a[i++] = Prop2.ToString();
                a[i++] = Prop3.ToString();
                return a ;
            }

        }

        public class GenericPropertyFinder<TModel> where TModel : class
        {
            public void PrintTModelPropertyAndValue(TModel tmodelObj)
            {
                //Getting Type of Generic Class Model
                Type tModelType = tmodelObj.GetType();

                //We will be defining a PropertyInfo Object which contains details about the class property 
                PropertyInfo[] arrayPropertyInfos = tModelType.GetProperties();

                //Now we will loop in all properties one by one to get value
                foreach (PropertyInfo property in arrayPropertyInfos)
                {
                    Console.WriteLine("Name of Property is\t:\t" + property.Name);
                    Console.WriteLine("Value of Property is\t:\t" + property.GetValue(tmodelObj).ToString());
                    Console.WriteLine(Environment.NewLine);
                }
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



    //extension method  
   
    
    

    class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }



}
