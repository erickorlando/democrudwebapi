using DataTransferObjects.Dto;
using DataTransferObjects.Request;
using DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using RestSharp;

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

        public AlumnoDto GetAlumno(int id)
        {
            var response = _restHelper.Execute<FiltroComunRequest, AlumnoResponse>("Alumno/Get", new FiltroComunRequest
            {
                Id = id
            });
            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);

            return response.Alumno;
        }

        public void Grabar(AlumnoDto dto)
        {
            var request = new AlumnoRequest
            {
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                CorreoElectronico = dto.CorreoElectronico,
                Edad = dto.Edad,
                FechaNacimiento = dto.FechaNacimiento,
                Id = dto.Id
            };

            string metodo;
            Method verbo;

            if (request.Id == 0)
            {
                metodo = "Alumno/Post";
                verbo = Method.POST;
            }
            else
            {
                metodo = "Alumno/Put";
                verbo = Method.PUT;
            }

            var response = _restHelper.Execute<AlumnoRequest, AlumnoResponse>(metodo, request, verbo);

            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);

        }

        public void Eliminar(int id)
        {
            var response = _restHelper.Execute<FiltroComunRequest, AlumnoResponse>("Alumno/Delete",
                new FiltroComunRequest
                {
                    Id = id
                }, Method.DELETE);

            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);
        }
    }
}
