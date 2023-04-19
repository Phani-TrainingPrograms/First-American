using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Ex08FunctionParameters
    {
        static void testFunc(int no)
        {
            no += 123;
            Console.WriteLine("The changed Value: " + no);
        }


        static void testFuncWithRef(ref int no)
        {
            no += 123;
            Console.WriteLine("The changed Value: " + no);
        }


        static void Main(string[] args)
        {
            int testNo = 456;
            Console.WriteLine("Value of testNo before sending to the function: " + testNo);
            //testFunc(testNo);//A value copy is passed...
            testFuncWithRef(ref testNo);//To pass an arg by ref...
            Console.WriteLine("Value of testNo after sending to the function: " + testNo);
            double res1, res2, res3, res4;
            mathOperation(123, 234, out res1, out res2, out res3, out res4);
            Console.WriteLine($"The Added value {res1}\nThe Subtracted Value:{res2}\nThe Multiplied Value: {res3}\nThe divided Value : {res4}");

            funcWithParams("String1", 123, true, DateTime.Now, "Different", "No ", "of ", "Parameters");

            Console.WriteLine("The added value is " + AddAllNumbers(123, 234));
            Console.WriteLine("The added value is " + AddAllNumbers(123, 234, 4356, 4567));
            Console.WriteLine("The added value is " + AddAllNumbers(123));
            Console.WriteLine("The added value is " + AddAllNumbers(123, 234, 45,56,78,78,56,56,56,56,56,56,67));
            Console.WriteLine("The added value is " + AddAllNumbers(123, 234));
        }
        public static int AddAllNumbers(params int [] values )
        {
            int res = 0;
            foreach (var val in values) res += val;
            return res;
        }
        private static void funcWithParams(params object[] args)
        {
            foreach (var name in args) Console.WriteLine(name);
        }

        private static void mathOperation(double v1, double v2, out double res1, out double res2, out double res3, out double res4)
        {
            res1 = v1 + v2;
            res2 = v1 - v2;
            res3 = v2 * v1;
            res4 = v1 / v2;
        }

    }
}
