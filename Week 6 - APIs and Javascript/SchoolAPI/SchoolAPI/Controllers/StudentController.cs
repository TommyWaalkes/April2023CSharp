﻿using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [ApiController]

    //This means use the Controller prefix for this section of the API 
    //So this controller will be at localhost:1000/Student
    [Route("[controller]")]
    public class StudentController :ControllerBase
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

        //There's 2 approaches to creating object with an API 
        //1) Fill out each property as a parameter to the API method 
        //2) Attach an object to the body of our HTTP call, this can be done through postman
        //It depends on whether or not the object has a lot of properties 
        //If it only has a few I'll do parameter but if it has 8+ properties, I will do it via the body

        //Anything that's not a get needs to be tested either through swagger or postman
        //Without a lot of hassle, browser cannot do not GET calls
        [HttpPost("Name{name}&Age{age}&AverageGrade{grade}&IsPassing{passing}")]
        public string CreateStudent(string name, int age, double grade, bool passing)
        {
            Student s = new Student() { Name = name, Age = age, AverageGrade = grade, IsPassing = passing };

            db.Students.Add(s);
            db.SaveChanges();

            return $"{name} was successfully added to the database";
        }

        [HttpPost]
        public string CreateStudent(Student newStudent)
        {
            db.Students.Add(newStudent);
            db.SaveChanges();

            return $"{newStudent.Name} was successfully added to the database";

        }

        [HttpDelete("{id}")]
        public string DeleteStudent(int id)
        {
            Student studentToDel = db.Students.Find(id);
            if (studentToDel != null)
            {
                db.Students.Remove(studentToDel);
                db.SaveChanges();
                return $"Student at {id} was deleted successfully";
            }
            else
            {
                return $"There was no student at {id}, nothing was deleted";
            }
        }

        //Update needs 2 things: new values to put into a row in the database and the Id of the entry you wish to update 
        //Updates will make a new object and override the old object, so any value you wish to leave alone, you need to put into 
        //the new model.

        [HttpPut("{id}")]
        public string UpdateStudent(Student newValues, int id)
        {
            newValues.Id = id;
            db.Students.Update(newValues);
            db.SaveChanges();

            return $"Student at {id} was updated successfully";
        }
    }
}
