using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Week2
{
    class Item : IComparable<Item>
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }

        //The compare function returns integer: -1(CUrrent object is smaller than the other), 0(They are equal) or 1(Current object is greater than the other).
        public int CompareTo(Item other)
        {
            return ItemName.CompareTo(other.ItemName);
        }
    }
    enum ItemComparingCriteria
    {
        Name, Price
    }
    class ItemComparer : IComparer<Item>
    {
        private ItemComparingCriteria condition;
        public ItemComparer(ItemComparingCriteria criteria)
        {
            this.condition = criteria;
        }
        public int Compare(Item x, Item y)
        {
            switch (condition)
            {
                case ItemComparingCriteria.Name:
                    return x.CompareTo(y);
                case ItemComparingCriteria.Price:
                   return x.ItemPrice.CompareTo(y.ItemPrice);
                 default:
                    return 0;
            }
        }
    }
    [Serializable]//For Binary Serialization......
    public class Employee
    {
        public DateTime EmpDob { get; set; }
        public double EmpSalary { get; set; }
        public string EmpEmail { get; set; }
        public string EmpName { get; set; }
        public int EmpId { get; set; }

        public override int GetHashCode()
        {
            return EmpId;
        }

        //Defines the Logical equivalence of 2 objects: Current object with the other
        public override bool Equals(object other)
        {
            if(other is Employee)//UNBOX THE object
            {
                Employee temp = other as Employee;
                return this.EmpId == temp.EmpId;
            }
            else
            {
                return false;
            }
        }
    }
}
//Issue: Adding duplicate objects in the Hashset is still adding the data
//Resolve: Override the GetHashCode method and Test it. 
//Still not resolved: Override the Equals method
//Test the code. 

