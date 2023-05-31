using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    //We put these tags here to tell C# we want this to be an API controller 
    //The route dictates root url of our API. When it's [controller], that means use the prefix to be our base url
    //Our prefix here would be Student
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        SchoolContext db = new SchoolContext();

        [HttpGet("getAll")]
        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return db.Students.Find(id);
        }

        //To test this endpoint we need to give our API call a body to pass along the object info. 
        //Easiest way to test this will be in postman
        [HttpPost]
        public void MakeStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteStudent(int id)
        {
            Student s = db.Students.Find(id);
            db.Students.Remove(s);
            db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void PutStudent(int id, Student student) {
            student.Id = id;
            db.Students.Update(student);
            db.SaveChanges();
        }
    }
}
