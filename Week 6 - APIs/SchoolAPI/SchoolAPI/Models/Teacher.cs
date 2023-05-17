namespace SchoolAPI.Models
{
    public class Teacher
    {

        public string Name { get; set; }
        public string SubjectTaught { get; set; }
        public int Age { get; set; }
        public int YearsTaught { get; set; }

        public Teacher(string name, string subjectTaught, int age, int yearsTaught)
        {
            Name = name;
            SubjectTaught = subjectTaught;
            Age = age;
            YearsTaught = yearsTaught;
        }


    }
}
