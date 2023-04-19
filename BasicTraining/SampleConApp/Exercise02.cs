using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Exercise02
    {
        const string menu = "------------------------CALC PROGRAM------------------------\n" +
            "SELECT THE OPERATION U WANT TO EXECUTE:\n" +
            "TO ADD--------------->PRESS 1\n" +
            "TO SUBTRACT---------->PRESS 2\n" +
            "TO MULTIPLY---------->PRESS 3\n" +
            "TO DIVIDE------------>PRESS 4\n" +
            "TO SQUARE------------>PRESS 5\n" +
            "TO FIND ROOT--------->PRESS 6\n" +
            "PS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................";
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                int choice = UIConsole.GetNumber(menu);
                processing = processMenu(choice);
                Console.WriteLine("Press any key to clear the Screen");
                Console.ReadKey();
                Console.Clear();
            } while (processing);
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1: addingOperation(); return true;
                case 2: subtractingOperation(); return true;
                case 3: multiplyOperation(); return true;
                case 4: divideOperation(); return true;
                case 5: squareOperation(); return true;
                case 6: sqrtOperation(); return true;
                    return true;
                default:
                    return false;
            }
        }

        private static void sqrtOperation()
        {
            double fValue = UIConsole.GetDouble("Enter the Value to Find its root");
            Console.WriteLine("The SquareRoot value: " + Math.Sqrt(fValue));
        }

        private static void squareOperation()
        {
            double fValue = UIConsole.GetDouble("Enter the Value to square");
            Console.WriteLine("The Square value: " + (fValue * fValue));
        }

        private static void divideOperation()
        {
            double fValue = UIConsole.GetDouble("Enter the First Value");
            double sValue = UIConsole.GetDouble("Enter the Second Value");
            Console.WriteLine("The Divided value: " + (fValue / sValue));
        }

        private static void multiplyOperation()
        {
            double fValue = UIConsole.GetDouble("Enter the First Value");
            double sValue = UIConsole.GetDouble("Enter the Second Value");
            Console.WriteLine("The Multiplied value: " + (fValue * sValue));
        }

        private static void subtractingOperation()
        {
            double fValue = UIConsole.GetDouble("Enter the First Value");
            double sValue = UIConsole.GetDouble("Enter the Second Value");
            Console.WriteLine("The Subtracted value: " + (fValue - sValue));
        }

        private static void addingOperation()
        {
            double fValue = UIConsole.GetDouble("Enter the First Value");
            double sValue = UIConsole.GetDouble("Enter the Second Value");
            Console.WriteLine("The Added value: " + (fValue + sValue));
        }
    }
}
