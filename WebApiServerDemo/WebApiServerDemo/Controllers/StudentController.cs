using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using StudentAccess;

namespace WebApiServerDemo.Controllers
{
    public class StudentController : ApiController
    {
        public IEnumerable<StudentInfo> Get()
        {
            using(StudentInfoEntities entities = new StudentInfoEntities())
            {
               return entities.StudentInfoes.ToList();
            }
        }
        public HttpResponseMessage Get(int id)
        {
            using (StudentInfoEntities entities = new StudentInfoEntities())
            {
                var entity= entities.StudentInfoes.FirstOrDefault(e => e.id== id);
                if(entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student id=" + id.ToString() + "Not Found");
                }
            }
        }

        public HttpResponseMessage Post([FromBody] StudentInfo student)
        {

            try
            {
                using (StudentInfoEntities entities = new StudentInfoEntities())
                {
                    entities.StudentInfoes.Add(student);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, student);
                    message.Headers.Location = new Uri(Request.RequestUri + student.id.ToString());
                    return message;
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
                using(StudentInfoEntities entities= new StudentInfoEntities())
                {
                    var entity = entities.StudentInfoes.FirstOrDefault(e => e.id == id);
                    if(entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "The Student with id: " + id.ToString() + " not found to delete");
                    }
                    else
                    {
                        entities.StudentInfoes.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        public HttpResponseMessage put(int id,[FromBody] StudentInfo student)
        {
            try
            {

            using(StudentInfoEntities entities = new StudentInfoEntities())
            {
                var entity = entities.StudentInfoes.FirstOrDefault(e => e.id == id);
                if(entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "the Student id : " + id.ToString() + " not found to update");

                }
                else
                {
                    entity.name = student.name;
                    entity.ht_no = student.ht_no;
                    entity.sec = student.sec;
                    entity.@class = student.@class;
                    entity.email = student.email;
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
    }
}
