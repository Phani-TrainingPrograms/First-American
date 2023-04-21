using System;

namespace SampleConApp
{
   
    class SuperClass
    {
        public void SuperFunc() => Console.WriteLine("Super!!!!!");
    }

    class SubClass : SuperClass
    {
        public new void SuperFunc() => Console.WriteLine("Superlative 2");
    }
    class Ex17MethodHiding
    {
        static void Main(string[] args)
        {
            SuperClass cls = new SuperClass();
            cls.SuperFunc();
            cls = new SubClass();
            cls.SuperFunc();

            SubClass child = new SubClass();
            child.SuperFunc();
        }
    }
}
