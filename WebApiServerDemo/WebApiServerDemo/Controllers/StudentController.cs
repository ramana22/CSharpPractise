using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
        public StudentInfo Get(int id)
        {
            using (StudentInfoEntities entities = new StudentInfoEntities())
            {
                return entities.StudentInfoes.FirstOrDefault(e => e.id== id);
            }
        }

        public void Post([FromBody] StudentInfo student)
        {
            using(StudentInfoEntities entities = new StudentInfoEntities())
            {
                entities.StudentInfoes.Add(student);
                entities.SaveChanges();
            }
        }
    }
}
