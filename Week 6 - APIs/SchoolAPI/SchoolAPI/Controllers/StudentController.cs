using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [ApiController]

    //This means use the Controller prefix for this section of the API 
    //So this controller will be at localhost:1000/Student
    [Route("[controller]")]
    public class StudentController
    {
        SchoolContext db = new SchoolContext();
        [HttpGet("Welcome")]
        public string GetWelcomeMessage()
        {
            return "Hello welcome to our student api";
        }

        //Anything I surround in {} the API will try to treat as a parameter 
        //For each input surrounded by {} in our HTtpGet 
        //The method MUST have a matching parameter. This applies to any datatype. 
        [HttpGet("{num1}/{num2}")]
        public int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpGet("Teacher/{index}")]
        public Teacher GetTeacher(int index)
        {
            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher("Dr Mario", "Medicine", 35, 20));
            teachers.Add(new Teacher("Shrek", "Biology", 1000, 100));
            teachers.Add(new Teacher("Luigi PHD MD JR", "Religion", 33, 10));

            //Error handling in APIs isn't much different from console apps. 
            //My trick is to return an object with an error in it if our validation fails, 
            //But feel free to use whatever means you can get working
            if (index >= 0 && index < teachers.Count)
            {
                return teachers[index];
            }
            else
            {
                Teacher error =
                    new Teacher($"Error Teacher at {index} was not found. Please input an int between 0 and {teachers.Count - 1}", "", -1, -1);
                return error;
            }
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            Student output = db.Students.Find(id);
            if (output != null)
            {
                return output;
            }
            else
            {
                return new Student() { Name=$"Error: id {id} is not a valid id in the db please try again",
                                        Age= 0, 
                                        AverageGrade= 0.0,
                                        IsPassing=false};
            }
        }
    }
}
