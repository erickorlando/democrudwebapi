using System.Collections.Generic;
using DataTransferObjects.Comun;
using Entidades;

namespace DataTransferObjects.Response
{
    public class ListadoCursosResponse : BaseResponse
    {
        public List<Curso> ListadoCursos { get; set; }
    }
}