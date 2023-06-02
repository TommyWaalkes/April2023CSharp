using System;
using System.Collections.Generic;

namespace SchoolBackend.Models;

//This model needs to match the datatype, spelling and casing from the database 
public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public double? AverageGrade { get; set; }

    public bool? IsPassing { get; set; }
}
