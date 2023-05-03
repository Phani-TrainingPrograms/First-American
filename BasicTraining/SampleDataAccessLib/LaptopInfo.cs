using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataAccessLib
{
    /// <summary>
    /// Represents the Laptop that is allocated to the Employee
    /// </summary>
    public class LaptopInfo
    {
        public int EntryId { get; set; }
        public string EmpName { get; set; }
        public string BrandName { get; set; }
        public string Series { get; set; }
        public double Price { get; set; }
    }
}
