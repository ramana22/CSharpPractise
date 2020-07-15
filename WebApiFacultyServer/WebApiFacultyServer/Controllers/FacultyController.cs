using FacultyInfoAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApiFacultyServer.Controllers
{
    public class FacultyController : ApiController
    {
        public IEnumerable<FacultyInfo> Get()
        {
            using(FacultyDataEntities entities = new FacultyDataEntities())
            {
                return entities.FacultyInfoes.ToList();
            }
        }

        public HttpResponseMessage get(int id)
        {
            using(FacultyDataEntities entities = new FacultyDataEntities())
            {
                var entity= entities.FacultyInfoes.FirstOrDefault(e => e.id == id);
                if(entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,"The Faculty with id: "+id.ToString()+" Not found");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
            }
        }


        public HttpResponseMessage Post([FromBody] FacultyInfo faculty)
        {
            try
            {

                using(FacultyDataEntities entities = new FacultyDataEntities())
                 {
                    entities.FacultyInfoes.Add(faculty);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, faculty);
                   message.Headers.Location = new Uri(Request.RequestUri + faculty.id.ToString());
                   return message;
                }

            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }

        }

        public HttpResponseMessage Put(int id ,[FromBody] FacultyInfo faculty)
        {
            try
            {
                using(FacultyDataEntities entities = new FacultyDataEntities())
                {
                    var entity = entities.FacultyInfoes.FirstOrDefault(e => e.id == id);
                    if(entity == null)
                    {
                      return  Request.CreateErrorResponse(HttpStatusCode.NotFound, "The faculty with id :" + id.ToString() + " Not found to update");
                    }
                    else
                    {
                        entity.name = faculty.name;
                        entity.phone = faculty.phone;
                        entity.dept = faculty.dept;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }
            }
            catch(Exception e)
            {
               return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
            using(FacultyDataEntities entities = new FacultyDataEntities())
            {
                var entity = entities.FacultyInfoes.FirstOrDefault(e => e.id == id);
                    if(entity == null)
                    {
                      return  Request.CreateErrorResponse(HttpStatusCode.NotFound, "The faculty with id :" + id.ToString() + " Not found to delete");
                    }
                    else
                    {
                        entities.FacultyInfoes.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
            }

            }catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }


    }
}
