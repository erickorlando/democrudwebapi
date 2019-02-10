using DataTransferObjects.Comun;
using System.Collections.Generic;
using Entidades;

namespace DataTransferObjects.Response
{
    public class ListadoAlumnosResponse : BaseResponse
    {
        public List<Alumno> ListaAlumnos { get; }

        public ListadoAlumnosResponse()
        {
            ListaAlumnos = new List<Alumno>();
        }
    }
}