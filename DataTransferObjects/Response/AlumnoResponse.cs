using DataTransferObjects.Comun;
using DataTransferObjects.Dto;

namespace DataTransferObjects.Response
{
    public class AlumnoResponse : BaseResponse
    {
        public AlumnoDto Alumno { get; set; }
    }
}