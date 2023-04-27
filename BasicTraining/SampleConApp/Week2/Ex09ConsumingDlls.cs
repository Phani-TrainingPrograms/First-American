using SampleDataAccessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Week2
{
    class Ex09ConsumingDlls
    {
        static void Main(string[] args)
        {
            var res = MathClass.AddFunc(123, 23);
            Console.WriteLine("The Result: " + res);
        }
    }
}
