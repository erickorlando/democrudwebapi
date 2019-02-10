using DataTransferObjects.Comun;
using DataTransferObjects.Request;
using System.Collections.Generic;

namespace DataTransferObjects.Response
{
    public class ListadoCursosResponse : BaseResponse
    {
        public List<CursoRequest> ListadoCursos { get; }

        public ListadoCursosResponse()
        {
            ListadoCursos = new List<CursoRequest>();
        }
    }
}