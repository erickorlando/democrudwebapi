using System;
using System.Collections.Generic;
using DataTransferObjects.Dto;
using DataTransferObjects.Request;
using DataTransferObjects.Response;
using RestSharp;

namespace Logica
{
    public class CursoClass
    {
        private readonly RestHelper _restHelper;

        public CursoClass()
        {
            _restHelper = new RestHelper();
        }

        public IEnumerable<CursoDto> GetAllCursos()
        {
            var response = _restHelper.Execute<FiltroComunRequest, ListadoCursosResponse>("Curso/GetAll", new FiltroComunRequest());
            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);

            return response.ListaCursos;
        }

        public CursoDto GetCurso(int id)
        {
            var response = _restHelper.Execute<FiltroComunRequest, CursoResponse>("Curso/Get", new FiltroComunRequest
            {
                Id = id
            });
            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);

            return response.Curso;
        }

        public void Grabar(CursoDto dto)
        {
            var request = new CursoRequest
            {
                NombreCurso = dto.NombreCurso,
                NombreProfesor = dto.NombreProfesor,
                FechaInicio = dto.FechaInicio,
                Id = dto.Id
            };

            string metodo;
            Method verbo;

            if (request.Id == 0)
            {
                metodo = "Curso/Post";
                verbo = Method.POST;
            }
            else
            {
                metodo = "Curso/Put";
                verbo = Method.PUT;
            }

            var response = _restHelper.Execute<CursoRequest, CursoResponse>(metodo, request, verbo);

            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);

        }

        public void Eliminar(int id)
        {
            var response = _restHelper.Execute<FiltroComunRequest, CursoResponse>("Curso/Delete",
                new FiltroComunRequest
                {
                    Id = id
                }, Method.DELETE);

            if (!response.Exito)
                throw new InvalidOperationException(response.MensajeError);
        }
    }
}