using System;
using System.Collections.Generic;

namespace DBtoRazor.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public int? GradeId { get; set; }

    public virtual Grade? Grade { get; set; }
}
