using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Ex07MathProgramExample
    {
        static void Main()
        {
            do
            {
                double firstNo = UIConsole.GetDouble("Enter the First Value");
                double secondNo = UIConsole.GetDouble("Enter the Second Value");
                string choice = UIConsole.GetString("Enter the Choice as + or - or X or /");
                double result = performOperation(firstNo, secondNo, choice);
                Console.WriteLine("The result of the operation is " + result);
                Console.WriteLine("Press any key to clear the screen");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        private static double performOperation(double firstNo, double secondNo, string choice)
        {
            double result = 0;
            switch (choice)
            {
                case "+": result = firstNo + secondNo; break;
                case "-": result = firstNo - secondNo; break;
                case "X": result = firstNo * secondNo; break;
                case "/": result = firstNo / secondNo; break;
                default:
                    break;
            }

            return result;
        }
    }
}
