using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Ex01ConsoleIO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the Age");
            var age = Console.ReadLine();

            Console.WriteLine("Enter UR College");
            var college = Console.ReadLine();

            var outputData = $"The Name entered is {name} studying in {college} with Mr.{name}'s age {age}";
            //Older syntax of string literal used with variable data. 
            outputData = string.Format("The Name entered is {0} studying in {1} and Mr.{0}'s age is {2}", name, college, age, "The name entered is ");
            Console.WriteLine(outputData);
        }
    }
}
//Todo: Explore on Read and ReadKey methods of the Console class and observe its differences and practical usages of these APIs. 
