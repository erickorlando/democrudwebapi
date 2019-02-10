using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Curso : EntityBase
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