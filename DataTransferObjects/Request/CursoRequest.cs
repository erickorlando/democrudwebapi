using System;
using System.ComponentModel.DataAnnotations;

namespace DataTransferObjects.Request
{
    public class CursoRequest
    {
        [Required]
        [StringLength(60)]
        public string NombreCurso { get; set; }
        public DateTime FechaInicio { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreProfesor { get; set; }
    }
}