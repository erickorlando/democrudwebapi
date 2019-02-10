using System;
using DataTransferObjects.Comun;
using Entidades;

namespace DataTransferObjects.Response
{
    public class AlumnoResponse : BaseResponse
    {
        public Alumno Alumno { get; set; }
    }
}