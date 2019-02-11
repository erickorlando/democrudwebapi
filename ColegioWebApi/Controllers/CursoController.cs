using DataTransferObjects.Dto;
using DataTransferObjects.Request;
using DataTransferObjects.Response;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace ColegioWebApi.Controllers
{
    [RoutePrefix("api/Curso")]
    public class CursoController : ApiController
    {
        [HttpPost]
        [Route("GetAll")]
        public ListadoCursosResponse GetAll(FiltroComunRequest request)
        {
            var response = new ListadoCursosResponse();
            try
            {
                var lista = new List<CursoDto>();
                using (var ctx = new ContextoDb())
                {
                    var allCursos = ctx.GetAllCursos(request.Filtro);

                    lista.AddRange(allCursos.Select(Curso => new CursoDto
                    {
                        Id = Curso.Id,
                        NombreCurso = Curso.NombreCurso,
                        NombreProfesor = Curso.NombreProfesor,
                        FechaInicio = Curso.FechaInicio
                    }));
                }

                response.ListaCursos = lista;
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
            }
            return response;
        }

        [HttpPost]
        [Route("Get")]
        public CursoResponse Get(FiltroComunRequest request)
        {
            var response = new CursoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetCurso(request.Id);
                    if (entidad == null)
                        throw new InvalidOperationException("No se encuentra el registro");

                    response.Curso = new CursoDto
                    {
                        Id = entidad.Id,
                        NombreCurso = entidad.NombreCurso,
                        NombreProfesor = entidad.NombreProfesor,
                        FechaInicio = entidad.FechaInicio
                    };
                }

                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
            }

            return response;
        }

        [HttpPost]
        [Route("Post")]
        public CursoResponse Post([FromBody]CursoRequest value)
        {
            var response = new CursoResponse();

            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = new Curso
                    {
                        NombreCurso = value.NombreCurso,
                        NombreProfesor = value.NombreProfesor,
                        FechaInicio = value.FechaInicio,
                    };

                    ctx.Set<Curso>().Add(entidad);
                    AsignarDto(response, entidad);
                    response.Exito = ctx.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
            }

            return response;
        }

        private static void AsignarDto(CursoResponse response, Curso entidad)
        {
            response.Curso = new CursoDto
            {
                Id = entidad.Id,
                NombreCurso = entidad.NombreCurso,
                NombreProfesor = entidad.NombreProfesor,
                FechaInicio = entidad.FechaInicio
            };
        }

        [HttpPut]
        [Route("Put")]
        public CursoResponse Put([FromBody]CursoRequest value)
        {
            var response = new CursoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetCurso(value.Id);

                    if (entidad == null)
                        throw new InvalidOperationException("Registro no existe");

                    entidad.NombreCurso = value.NombreCurso;
                    entidad.NombreProfesor = value.NombreProfesor;
                    entidad.FechaInicio = value.FechaInicio;

                    ctx.Set<Curso>().Attach(entidad);
                    ctx.Entry(entidad).State = EntityState.Modified;

                    AsignarDto(response, entidad);
                    response.Exito = ctx.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
            }

            return response;
        }

        [HttpDelete]
        [Route("Delete")]
        public CursoResponse Delete(FiltroComunRequest request)
        {
            var response = new CursoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetCurso(request.Id);

                    if (entidad == null)
                        throw new InvalidOperationException("Registro no existe");

                    ctx.Set<Curso>().Attach(entidad);
                    ctx.Entry(entidad).State = EntityState.Deleted;

                    response.Exito = ctx.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
            }
            return response;
        }
    }
}
