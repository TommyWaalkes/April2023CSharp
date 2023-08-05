using System;
using System.Collections.Generic;

namespace ToDoBackend.Models;

public partial class ToDo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? AssignedTo { get; set; }

    public int? HoursNeeded { get; set; }

    public bool? IsComplete { get; set; }

    public virtual Employee? AssignedToNavigation { get; set; }
}
