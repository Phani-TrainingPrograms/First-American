using System;

namespace SampleConApp
{
    class Ex03ReferenceTypes
    {
        static void Main(string[] args)
        {
            object data = 123;//Data type is object and the internal type is int. 
            data = "Some string";
            data = true;
            Console.WriteLine("The Data type is " + data.GetType().Name);

            //BOXING AND UNBOXING FEATURE:
            object value = 123;//data type is int, but is boxed. 
            //value += 123;//Cannot do this untill U unbox it. as += is an operator for int not for object. 
            long unboxedLong = (int)value;//UNBOX it to the same type from which it was boxed.
            Console.WriteLine(unboxedLong);
            int unBoxedValue = (int)value;//UNBOXING syntax....
            unBoxedValue++;//perform any kind of Integral operation...
            value = unBoxedValue;//reset it back to object(implicit)
            Console.WriteLine(value);//display the object data. 
        }
    }
}