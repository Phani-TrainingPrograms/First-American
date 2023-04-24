using System;
using System.Collections.Generic;

//Sorting internally looks for an interface called IComparable<T> or IComparer<T>. 
namespace SampleConApp.Week2
{
    class Ex04SortingItems
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { ItemName = "Samsung TV", ItemPrice = 65000 });
            items.Add(new Item { ItemName = "Apple TV", ItemPrice = 145000 });
            items.Add(new Item { ItemName = "MI TV", ItemPrice = 35000 });
            items.Add(new Item { ItemName = "Onida TV", ItemPrice = 25000 });
            items.Add(new Item { ItemName = "Sony TV", ItemPrice = 90000 });
            items.Add(new Item { ItemName = "Oppo TV", ItemPrice = 50000 });

            string choice = UIConsole.GetString("Select 1 for sorting by Name or 2 for Price");
            if (choice == "1")
            {
                items.Sort();//Will call the IComparable's CompareTo method....
            }
            else if (choice == "2")
            {
                items.Sort(new ItemComparer(ItemComparingCriteria.Price));
            }
            foreach (var item in items)
                Console.WriteLine(item.ItemName + "====>" + item.ItemPrice);

        }
    }
}

