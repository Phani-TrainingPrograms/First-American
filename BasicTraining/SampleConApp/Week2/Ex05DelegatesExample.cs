using System;
namespace SampleConApp.Week2
{
    delegate double Operation(double v1, double v2);
    class MathProgram
    {
        public static void PerformOperation(double iVal1, double iVal2, Operation func)
        {
            var result = func(iVal1, iVal2);
            Console.WriteLine("The Result of this operation is " + result);
        }

    }
    class Ex05DelegatesExample
    {
        static double addFunc(double v1, double v2) => v1 + v2;
        static void Main(string[] args)
        {
            //MathProgram.PerformOperation(123, 234, callMe);
            //MathProgram.PerformOperation(123, 234, addFunc);

            //MathProgram.PerformOperation(123, 2, (x, y) =>{
            //    return x * y;
            //});
            Utilities.Display("FuncAndAction", actionAndFuncDemo);
            Utilities.Display("MulticastDelegate", multiCastDelegateDemo);
        }

        private static void multiCastDelegateDemo()
        {
            Action func = () => Console.WriteLine("First Function");
            func += () => Console.WriteLine("Second Function");
            func += () => Console.WriteLine("Third Function");
            func += () => Console.WriteLine("Fourth Function");
            func += () => Console.WriteLine("Fifth Function");

            func();

            Func<double, double, double> mathFunc = (v1, v2) => v1 + v2;
            mathFunc += (v1, v2) => v1 - v2;
            mathFunc += (v1, v2) => v1 * v2;
            mathFunc += (v1, v2) => v1 / v2;

            var res = mathFunc(13, 12);//Gets the result of the last associated Function
            Console.WriteLine(res); 
            var allFunctions = mathFunc.GetInvocationList();
            foreach(Delegate f in allFunctions)
            {
                var data = f.DynamicInvoke(13, 12);
                Console.WriteLine(data);
            }
        }

        private static void actionAndFuncDemo()
        {
            Func<double, double> sqr = (v1) => v1 * v1;
            var res = sqr(12);
            Console.WriteLine(res);

            Func<double, double, double> func = (v1, v2) => v1 * v2;
            res = func(13, 12);
            Console.WriteLine(res);

            Action act1 = () => Console.WriteLine("Method with no args");
            Action<double> act2 = (v1) => Console.WriteLine("Method with arg " + v1);

            act1();
            act2(123);
        }

        static double callMe(double v2, double v1)
        {
            var res = v1 * v2 - (123 + 12) * 4 - v1;
            return res;
        }

    }
}
