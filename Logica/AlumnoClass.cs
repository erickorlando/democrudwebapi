using DataTransferObjects.Dto;
using DataTransferObjects.Request;
using DataTransferObjects.Response;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class AlumnoClass
    {
        private readonly RestHelper _restHelper;

        public AlumnoClass()
        {
            _restHelper = new RestHelper();
        }

        public IEnumerable<AlumnoDto> GetAllAlumnos()
        {
            var response = _restHelper.Execute<FiltroComunRequest, ListadoAlumnosResponse>("Alumno/GetAll", new FiltroComunRequest());
            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);

            return response.ListaAlumnos;
        }

    }
}
