using DataTransferObjects.Comun;
using DataTransferObjects.Dto;
using System.Collections.Generic;

namespace DataTransferObjects.Response
{
    public class ListadoCursosResponse : BaseResponse
    {
        public List<CursoDto> ListaCursos { get; set; }

        public ListadoCursosResponse()
        {
            ListaCursos = new List<CursoDto>();
        }
    }
}