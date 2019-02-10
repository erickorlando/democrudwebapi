using System;

namespace DataTransferObjects.Dto
{
    public class AlumnoDto
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public string CorreoElectronico { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}