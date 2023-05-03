using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_DataAccessProgram
{
    class UIConsole
    {
        internal static void ClearScreen()
        {
            Console.WriteLine("Press any key to clear the Screen");
            Console.ReadKey();
            Console.Clear();
        }
        internal static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        internal static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }

        internal static double GetDouble(string question)
        {
            return double.Parse(GetString(question));
        }

        internal static long GetLong(string question)
        {
            return long.Parse(GetString(question));
        }

        internal static DateTime GetDate(string question)
        {
            Console.WriteLine(question);
            Console.WriteLine("Enter the date as dd/MM/yyyy");
            return DateTime.Parse(Console.ReadLine());
        }

        internal static void PrintMessage(string message)
        {
            var oldBgColor = Console.BackgroundColor;
            var oldFgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = oldFgColor;
            Console.BackgroundColor = oldBgColor;
        }

        internal static void PrintError(string message)
        {
            var oldBgColor = Console.BackgroundColor;
            var oldFgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = oldFgColor;
            Console.BackgroundColor = oldBgColor;
        }
    }
}
