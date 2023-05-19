using System;
using System.Collections.Generic;

namespace SampleMvcApp.Data;

public partial class TblCity
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();
}
