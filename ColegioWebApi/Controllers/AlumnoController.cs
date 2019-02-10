using DataTransferObjects.Request;
using DataTransferObjects.Response;
using Datos;
using Entidades;
using System;
using System.Web.Http;

namespace ColegioWebApi.Controllers
{
    public class AlumnoController : ApiController
    {
        // GET api/<controller>
        public ListadoAlumnosResponse Get()
        {
            var response = new ListadoAlumnosResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    response.ListaAlumnos.AddRange(ctx.GetAllAlumnos());
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

        // GET api/<controller>/5
        public Alumno Get(int id)
        {
            using (var ctx = new ContextoDb())
            {
                return ctx.GetAlumno(id);
            }
        }

        // POST api/<controller>
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

        // PUT api/<controller>/5
        public AlumnoResponse Put(int id, [FromBody]AlumnoRequest value)
        {
            var response = new AlumnoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetAlumno(id);

                    if (entidad == null)
                        throw new InvalidOperationException("Registro no existe");

                    entidad.Nombres = value.Nombres;
                    entidad.Apellidos = value.Apellidos;
                    entidad.CorreoElectronico = value.CorreoElectronico;
                    entidad.Edad = value.Edad;
                    entidad.FechaNacimiento = value.FechaNacimiento;

                    ctx.Set<Alumno>().Add(entidad);
                    response.Exito = ctx.SaveChanges() > 0;
                    response.AlumnoId = entidad.Id;
                }
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
            }

            return response;
        }

        // DELETE api/<controller>/5
        public AlumnoResponse Delete(int id)
        {
            var response = new AlumnoResponse();
            try
            {
                using (var ctx = new ContextoDb())
                {
                    var entidad = ctx.GetAlumno(id);

                    if (entidad == null)
                        throw new InvalidOperationException("Registro no existe");

                    ctx.Set<Alumno>().Remove(entidad);

                    ctx.SaveChanges();
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