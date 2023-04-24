using System;
using System.Collections.Generic;
using System.Linq;
namespace SampleConApp.Week2
{
    class Ex03GenericsExample
    {
        static void Main(string[] args)
        {
            //queueExample();
            //stackExample();
            sortedListExample();
        }

        private static void sortedListExample()
        {
            SortedList<string, int> data = new SortedList<string, int>();
            data.Add("Apples", 5);
            data.Add("Mangoes", 15);
            data.Add("Oranges", 4);
            data.Add("Bananas", 8);
            data.Add("Kiwi Fruits", 4);
            foreach(var item in data)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
                //Output comes in the sorted order of the keys...
            }

            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data.Keys[i]);
            }
            //Todo: Create an Example on SortedDictionary and see how it behaves. Refer the MSDN and note the differences of SortedList vs. SortedDictionary.
            //
            SortedDictionary<string, int> data2 = new SortedDictionary<string, int>(data);
            foreach(var pair in data2)
                Console.WriteLine(pair.Value);
        }

        private static void stackExample()
        {
            Stack<String> pages = new Stack<string>();
            int i = 0;
            do
            {
                pages.Push(UIConsole.GetString("Enter the Page to View"));
                foreach (var page in pages) Console.WriteLine(page);
                Console.WriteLine("\n\n");
                i++;
            } while (i < 2);
            //Remove the pages from the Stack
            i = pages.Count;
            do
            {
                --i;
                Console.WriteLine(pages.Pop() + " is removed");//Removes the Top page from the phone...
            } while (i > 0);
        }

        private static void queueExample()
        {
            Queue<string> recentList = new Queue<string>();
            do
            {
                var input = UIConsole.GetString("Enter the Item to view");
                if (recentList.Count == 5)
                    recentList.Dequeue();//Removes the 1st item in the Collection
                recentList.Enqueue(input);//Adds the item to the bottom of the collection. 
                displayQueueItems(recentList);
            } while (true);
        }

        private static void displayQueueItems(Queue<string> recentList)
        {
            Console.WriteLine("The Recent List of Items:");
            var list = recentList.Reverse();
            foreach(var item in list)
                Console.WriteLine(item);            
        }
    }
}