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
            int[] values = { 12, 45, 65, 45, 23, 78, 90 };//latest syntax of array....

            foreach (int res in results) Console.Write(res + " ");
            ///////////////////////////////////Multi Dimensional Array//////////////////////////
            //int[,] TwoDArray = { { 23, 45, 67 }, { 56, 78, 67 }, { 66, 45, 89 }, { 56, 77, 90 } };
            //Console.WriteLine("The No of dimensions: " + TwoDArray.Rank);
            //Console.WriteLine("The Length of the 1st dimension: " + TwoDArray.GetLength(0));
            //Console.WriteLine("The Length of the 2nd dimension: " + TwoDArray.GetLength(1));
            //Console.WriteLine("Display in Matrix Format");
            //for (int i = 0; i < TwoDArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDArray.GetLength(1); j++)
            //    {
            //        Console.Write(TwoDArray[i, j] + "   ");
            //    }
            //    Console.WriteLine();//Moves to the next
            //}
            /////////////////////////////////////////Jagged Array//////////////////////////////////
            int[][] school = new int[5][]; //Intension is to have rows with variable no of columns in each row. We now have 5 rows in the Jagged Array.
            school[0] = new int [] { 45,45,56,67,78,89,45};
            school[1] = new int[] { 67, 77, 89, 77, 87 };
            school[2] = new int[] { 56, 67, 89 };
            school[3] = new int[] { 78, 78, 99, 23, 45, 67, 89, 76, 54 };
            school[4] = new int[] { 77, 66, 55, 44, 33 };

            //Display the data in the matrix format...
            for (int i = 0; i < school.Length; i++)
            {
                foreach(int score in school[i])
                {
                    Console.Write(score + "  ");
                }
                Console.WriteLine();
            }
            ////////////////////////////////////////Dynamic Array creation////////////////////
            //To create an Array U need the following things:
            //Data type of the Array, Size of the Array. 
            Console.WriteLine("Enter the size of the Array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CTS equivalent Data type for the Array");
            string typeName = Console.ReadLine();
            Type selectedDataType = Type.GetType(typeName, false, true);
            if(selectedDataType == null)
            {
                Console.WriteLine("Invalid CTS type, not supported");
                return;
            }
            Array instance = Array.CreateInstance(selectedDataType, size);
            //Creates the instance of the Array based in the CTS type passed as first arg and the size as the second arg, it returns the created array object. 
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the index {i} of the data type {selectedDataType.Name}");//Name is the builtin property of the Type class that gets the Name of the data type. 
                string input = Console.ReadLine();
                instance.SetValue(Convert.ChangeType(input, selectedDataType), i);
            }
            Console.WriteLine("All the values are set, Now its time to read the data");
            foreach(var item in instance)
                Console.WriteLine(item);
        }
    }
}
