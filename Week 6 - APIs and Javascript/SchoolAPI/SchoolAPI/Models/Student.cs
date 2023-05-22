using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public double? AverageGrade { get; set; }

    public bool? IsPassing { get; set; }
}
