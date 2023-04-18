using System;

namespace SampleConApp
{
    class Ex02DataTypes
    {
        static void Main(string[] args)
        {
            //Syntax is similar to C++...
            int iValue = 123;
            double dValue = 3245.56;
            float fValue = 345.46f;//use the suffix f for float, else it will be double. 
            short sValue = 345;
            DateTime dt = DateTime.Now;
            Console.WriteLine("The integer is " + iValue);
            Console.WriteLine("The double is " + dValue);
            Console.WriteLine("The Float is " + fValue);
            Console.WriteLine("The Short is " + sValue);
            Console.WriteLine("The Current Date is " + dt);

            Console.WriteLine($"The range of byte is {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The range of short is {short.MinValue} and {short.MaxValue}");
            Console.WriteLine($"The range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} and {long.MaxValue}");
            Console.WriteLine($"The range of float is {float.MinValue} and {float.MaxValue}");
            Console.WriteLine($"The range of double is {double.MinValue} and {double.MaxValue}"); 
            Console.WriteLine($"The range of decimal is {decimal.MinValue} and {decimal.MaxValue}");
            Console.WriteLine($"The range of Bool is true and false");

            string intValue = iValue.ToString();//ToString is a function of the base class of all Data types called object which converts the type to String representation. 
            Console.WriteLine(intValue + " converted as string");

            //////////Data Conversions/////
            double dVal = Convert.ToDouble(123);
            iValue = 123;
            dVal = iValue;//double is larger than int..
            iValue = (int)dVal;
        }
    }
}