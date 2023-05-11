using System;
using System.Collections.Generic;

namespace EFLecture.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public float? Salary { get; set; }
}
