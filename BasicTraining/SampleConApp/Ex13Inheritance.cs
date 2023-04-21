using System;

namespace SampleConApp
{
    class BaseClass
    {
        private void helperMethod() => Console.WriteLine("Used by other methods of the class");
        public void TestFunc()
        {
            helperMethod();
            Console.WriteLine("Base class Func");
        }
    }

    class DerivedClass : BaseClass
    {
        public void DerivedFunc() => Console.WriteLine("Derived class Func");
    }

    class Ex13Inheritance
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.TestFunc();//Internally call the helperMethod
            derived.DerivedFunc();
            
        }
    }
}
