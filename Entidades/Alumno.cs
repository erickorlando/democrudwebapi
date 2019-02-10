using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Alumno : EntityBase
    {
        [Required]
        [StringLength(60)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(60)]
        public string Apellidos { get; set; }

        public int Edad { get; set; }

        [StringLength(200)]
        public string CorreoElectronico { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}