namespace SampleMvcApp.Models
{
    public class Employee
    {
        public int EmpId{ get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Salary { get; set; }
        public long MobileNo { get; set; }
    }
}
