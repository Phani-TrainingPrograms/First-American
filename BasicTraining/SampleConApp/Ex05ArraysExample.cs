using System;
namespace SampleConApp
{
    class Ex05ArraysExample
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////Single dimensional Array Example//////////////////////////////////////////////////////
            int[] array = new int[5];//default value will be 0. Here we have created an array of the type int whose size is 10 which will internally have the default value as its elements data. 
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Enter the value for the position {0}", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("All values are set, now lets read the values");
            ////foreach is safer way of reading elements within an array as U dont need to know the size of the array and will always be within the bounds of the array
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            int[] results = new int[] { 12, 45, 65, 45, 23 };
            int[] values = { 12,45,65,45,23,78,90 };//latest syntax of array....

            foreach (int res in results) Console.Write(res + " ");
            ////////////////////////////////////////Multi Dimensional Array/////////////////////////////////////////////////////////////
            int[,] TwoDArray = { { 23, 45, 67 }, { 56, 78, 67 }, { 66, 45, 89 }, { 56, 77, 90 } };
            Console.WriteLine("The No of dimensions: " + TwoDArray.Rank);
            Console.WriteLine("The Length of the 1st dimension: " + TwoDArray.GetLength(0));
            Console.WriteLine("The Length of the 2nd dimension: " + TwoDArray.GetLength(1));
            Console.WriteLine("Display in Matrix Format");
            for(int i =0; i < TwoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDArray.GetLength(1); j++)
                {
                    Console.Write(TwoDArray[i, j] + "   ");
                }
                Console.WriteLine();//Moves to the next
            }
        }   
    }
}
