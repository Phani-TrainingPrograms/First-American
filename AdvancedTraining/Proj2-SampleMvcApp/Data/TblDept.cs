using System;
using System.Collections.Generic;

namespace SampleMvcApp.Data;

public partial class TblDept
{
    public int DeptId { get; set; }

    public string DeptName { get; set; } = null!;

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();
}
