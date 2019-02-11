using System;

namespace DataTransferObjects.Dto
{
    public class CursoDto
    {
        public int Id { get; set; }
        public string NombreCurso { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NombreProfesor { get; set; }
    }
}