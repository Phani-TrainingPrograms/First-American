using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Ex06Functions
    {
        
        static void Main(string[] args)
        {
            var name = UIConsole.GetString("Enter the Name");
            var address = UIConsole.GetString("Enter the Address");
            var age = UIConsole.GetNumber("Enter the Age");
            var salary = UIConsole.GetDouble("Enter the Salary");
            Console.WriteLine($"The Name entered is {name} from {address} whose age is {age} earning a salary of {salary:C}");
            
        }
    }
}
