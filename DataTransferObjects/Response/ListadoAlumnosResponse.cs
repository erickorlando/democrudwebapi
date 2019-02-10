using DataTransferObjects.Comun;
using DataTransferObjects.Dto;
using System.Collections.Generic;

namespace DataTransferObjects.Response
{
    public class ListadoAlumnosResponse : BaseResponse
    {
        public List<AlumnoDto> ListaAlumnos { get; set; }

        public ListadoAlumnosResponse()
        {
            ListaAlumnos = new List<AlumnoDto>();
        }
    }
}