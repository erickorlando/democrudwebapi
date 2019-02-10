using DataTransferObjects.Request;
using DataTransferObjects.Response;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataTransferObjects.Dto;

namespace ColegioWebApi.Controllers
{
    [RoutePrefix("api/Alumno")]
    public class AlumnoController : ApiController
    {
        [HttpPost]
        [Route("GetAll")]
        public ListadoAlumnosResponse GetAll(FiltroComunRequest request)
        {
            var response = new ListadoAlumnosResponse();
            try
            {
                var lista = new List<AlumnoDto>();
                using (var ctx = new ContextoDb())
                {
                    var allAlumnos = ctx.GetAllAlumnos(request.Filtro);

                    lista.AddRange(allAlumnos.Select(alumno => new AlumnoDto
                    {
                        Id = alumno.Id,
                        Nombres = alumno.Nombres,
                        Apellidos = alumno.Apellidos,
                        CorreoElectronico = alumno.CorreoElectronico,
                        Edad = alumno.Edad,
                        FechaNacimiento = alumno.FechaNacimiento
                    }));
                }

                response.ListaAlumnos = lista;
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
        public AlumnoResponse Get(FiltroComunRequest request)
        {
            var response = new AlumnoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    response.Alumno = ctx.GetAlumno(request.Id);
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
        public AlumnoResponse Post([FromBody]AlumnoRequest value)
        {
            var response = new AlumnoResponse();

            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = new Alumno
                    {
                        Nombres = value.Nombres,
                        Apellidos = value.Apellidos,
                        CorreoElectronico = value.CorreoElectronico,
                        Edad = value.Edad,
                        FechaNacimiento = value.FechaNacimiento
                    };

                    ctx.Set<Alumno>().Add(entidad);
                    response.Alumno = entidad;
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

        [HttpPut]
        [Route("Put")]
        public AlumnoResponse Put([FromBody]AlumnoRequest value)
        {
            var response = new AlumnoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetAlumno(value.Id);

                    if (entidad == null)
                        throw new InvalidOperationException("Registro no existe");

                    entidad.Nombres = value.Nombres;
                    entidad.Apellidos = value.Apellidos;
                    entidad.CorreoElectronico = value.CorreoElectronico;
                    entidad.Edad = value.Edad;
                    entidad.FechaNacimiento = value.FechaNacimiento;

                    ctx.Set<Alumno>().Add(entidad);
                    response.Alumno = entidad;
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
        public AlumnoResponse Delete(FiltroComunRequest request)
        {
            var response = new AlumnoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetAlumno(request.Id);

                    if (entidad == null)
                        throw new InvalidOperationException("Registro no existe");

                    ctx.Set<Alumno>().Remove(entidad);

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