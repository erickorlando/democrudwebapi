namespace Entidades
{
    public class AlumnoCurso : EntityBase
    {
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}