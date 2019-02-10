using Entidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Datos
{
    public class ContextoDb : DbContext
    {

        public ContextoDb()
            : base("Colegio")
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlumnoCurso> AlumnoCursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Para evitar la pluralizacion en los nombres de las tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public IEnumerable<Alumno> GetAllAlumnos()
        {
            return Alumnos.ToList();
        }

        public Alumno GetAlumno(int id)
        {
            return Alumnos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Curso> GetAllCursos()
        {
            return Cursos.ToList();
        }

        public Curso GetCurso(int id)
        {
            return Cursos.FirstOrDefault(p => p.Id == id);
        }
    }
}
