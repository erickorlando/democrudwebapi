using System;
using System.ComponentModel.DataAnnotations;

namespace DataTransferObjects.Request
{
    public class AlumnoRequest
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
