using System.Collections.Generic;
using DataTransferObjects.Comun;
using Entidades;

namespace DataTransferObjects.Response
{
    public class ListadoAlumnosResponse : BaseResponse
    {
        public List<Alumno> ListaAlumnos { get; set; }

        public ListadoAlumnosResponse()
        {
            ListaAlumnos = new List<Alumno>();
        }
    }
}