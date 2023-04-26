using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Week2
{
    //delegate void InvokeFunc();
    class Utilities
    {
        public static void Display(string message, Action funcToDemo)
        {
            Console.WriteLine($"-------------------Example For {message}-------------");
            funcToDemo();
            Console.WriteLine("----------------End of the Example--------------");
        }
    }
}
