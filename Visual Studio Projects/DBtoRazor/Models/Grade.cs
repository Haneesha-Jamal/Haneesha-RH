using System;
using System.Collections.Generic;

namespace DBtoRazor.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public string? Grade1 { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
