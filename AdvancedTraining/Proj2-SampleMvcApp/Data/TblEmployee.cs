using System;
using System.Collections.Generic;

namespace SampleMvcApp.Data;

public partial class TblEmployee
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public long EmpPhone { get; set; }

    public decimal EmpSalary { get; set; }

    public int? DeptId { get; set; }

    public int? CityId { get; set; }

    public virtual TblCity? City { get; set; }

    public virtual TblDept? Dept { get; set; }
}
