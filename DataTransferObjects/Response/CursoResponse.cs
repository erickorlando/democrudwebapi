using DataTransferObjects.Comun;
using DataTransferObjects.Dto;

namespace DataTransferObjects.Response
{
    public class CursoResponse : BaseResponse
    {
        public CursoDto Curso { get; set; }
    }
}