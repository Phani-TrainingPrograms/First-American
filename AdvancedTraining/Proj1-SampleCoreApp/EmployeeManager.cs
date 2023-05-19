namespace SampleCoreApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Salary { get; set; }
    }
    public class EmployeeManager
    {
        public List<Employee> GetAllEmployees()
        {
            var data = new List<Employee>
            {
                new Employee{ Id = 1, Name="Phaniraj", Address="Bangalore", Salary=1000},
                new Employee{ Id = 2, Name="Sahana", Address="Mysore", Salary=5000},
                new Employee{ Id = 3, Name="Aditya", Address="Nagpur", Salary=1600},
                new Employee{ Id = 4, Name="Leheri", Address="Chennai", Salary=4000},
                new Employee{ Id = 5, Name="Junaid", Address="Meerut", Salary=1450},
                new Employee{ Id = 6, Name="Abhisek", Address="Gurugram", Salary=1450},
                new Employee{ Id = 7, Name="NavDeep", Address="Amritsar", Salary=1650}
            };
            return data;
        }
    }

}