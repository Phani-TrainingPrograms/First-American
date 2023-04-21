using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    interface IMathTest
    {
        void ConductTest();
    }

    interface IScienceTest
    {
        void ConductTest();
    }

    class SchoolExam : IMathTest, IScienceTest
    {
        void IMathTest.ConductTest() => Console.WriteLine("Math Test is implemented");
        void IScienceTest.ConductTest() => Console.WriteLine("Science Test is implemented");

        public void ConductTest() => Console.WriteLine("Both the tests are implemented");
    }
    interface IExample
    {
        void ExampleFunc();
    }

    interface ISimple
    {
        void SimpleFunc();
    }

    class ExampleImpl : IExample, ISimple
    {
        private int data = 0;
        public void ExampleFunc() => data = 123;

        public void SimpleFunc() => Console.WriteLine(data);
    }
    class Ex16Interfaces
    {
        static void Main(string[] args)
        {
            //FirstExample();

            ExplicitImplementationExample();

        }

        private static void ExplicitImplementationExample()
        {
            IMathTest test1 = new SchoolExam();
            test1.ConductTest();

            IScienceTest test2 = new SchoolExam();
            test2.ConductTest();

            SchoolExam exam = new SchoolExam();
            exam.ConductTest();
        }

        private static void FirstExample()
        {
            IExample obj = new ExampleImpl();
            obj.ExampleFunc();

            //ISimple sim = (ISimple)obj;
            if (obj is ISimple)
            {
                ISimple sim = obj as ISimple;
                sim.SimpleFunc();
            }
            else
            {
                Console.WriteLine("Not implemented");
            }
        }
    }
}
