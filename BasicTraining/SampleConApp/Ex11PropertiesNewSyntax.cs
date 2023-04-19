using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public long EmpPhone { get; set; }
        public int EmpSalary { get; set; }
    }
    class Ex11PropertiesNewSyntax
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                EmpId = 123,
                EmpAddress = "Bangalore",
                EmpName = "Phaniraj",
                EmpPhone = 23424324,
                EmpSalary = 56000
            };//Initialization Syntax

            Console.WriteLine($"The Name is {emp.EmpName} from {emp.EmpAddress} earning a salary of {emp.EmpSalary} with a contact no as {emp.EmpPhone}");
        }
    }
}
