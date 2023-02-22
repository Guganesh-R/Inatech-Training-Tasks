using System;
using System.Collections.Generic;

namespace EFDbConne.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? Gender { get; set; }

    public int? DeptId { get; set; }

    public string? Desgination { get; set; }

    public virtual Department? Dept { get; set; }
}
