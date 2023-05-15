using System;
using System.Collections.Generic;

namespace AdoptionLab.Models;

public partial class Pet
{
    public int Id { get; set; }

    public string? Img { get; set; }

    public string? Breed { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Description { get; set; }
}
