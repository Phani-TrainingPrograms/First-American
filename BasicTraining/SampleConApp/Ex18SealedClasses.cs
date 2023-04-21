using System;

namespace SampleConApp
{
    sealed class ConcreteClass
    {
        public void SampleFunc() => Console.WriteLine("Sample Func");
    }

    class FirstClass //: ConcreteClass => Not possible
    {
        public virtual void Func() => Console.WriteLine("Base Func");
    }

    class SealedMethodClass : FirstClass
    {
        public sealed override void Func()//Only overriden methods can be sealed
        {
            base.Func();
            Console.WriteLine("Last level of overriding, Cannot override further");
        }
    }

    class SealedMethodClass2 : SealedMethodClass
    {
        //override wont list the Func method as its sealed.  
    }
    class Ex18SealedClasses
    {
        static void Main(string[] args)
        {
            SealedMethodClass2 cls = new SealedMethodClass2();
            cls.Func();
        }
    }
}
