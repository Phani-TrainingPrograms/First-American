using System;
using System.Collections.Generic;//namespace for Generic Collections

namespace SampleConApp.Week2
{
    class Ex01GenericCollections
    {
        static void Main(string[] args)
        {
            //listExample();
            //employeeListExample();
            //hashsetExample();
            employeeHashSetExample();
        }

        private static Employee createEmployee()
        {
            var id = UIConsole.GetNumber("Enter the Id");
            var salary = UIConsole.GetDouble("Enter the Salary");
            var name = UIConsole.GetString("Enter the Name");
            var email = UIConsole.GetString("Enter the Email Address");
            var dob = UIConsole.GetDate("Enter the date of birth");
            return new Employee
            {
                EmpId = id, EmpDob = dob, EmpEmail = email, EmpName = name, EmpSalary = salary
            };
        }
        private static void employeeHashSetExample()
        {
            HashSet<Employee> uniqueTeam = new HashSet<Employee>();
            //hashCodeExample(uniqueTeam);//Example to show how HashCode works. 
            do
            {
                if(!uniqueTeam.Add(createEmployee()))
                    Console.WriteLine("Employee already exists");
                else
                {
                    Console.WriteLine("The List of Employees: ");
                    foreach(var emp in uniqueTeam)
                        Console.WriteLine(emp.EmpName);
                }
            } while (true);
            
            Console.WriteLine("The Total employees with us: " + uniqueTeam.Count);

        }

        private static void hashCodeExample(HashSet<Employee> uniqueTeam)
        {
            Employee emp = new Employee { EmpId = 12345 };
            uniqueTeam.Add(emp);
            Employee temp = emp;
            if (uniqueTeam.Add(temp) == false)
            {
                Console.WriteLine("The Employee is already added");
            }
            Console.WriteLine("The hashCode for the first: " + emp.GetHashCode());
            Console.WriteLine("The hashCode for the second: " + temp.GetHashCode());
        }

        private static void hashsetExample()
        {
            HashSet<string> cart = new HashSet<string>();
            do
            {
                string fruit = UIConsole.GetString("Enter the fruit to add to the cart");
                if(cart.Add(fruit) == false)
                {
                    Console.WriteLine("Fruit is already added to the cart");
                }
                else 
                { 
                    foreach (var item in cart) Console.WriteLine(item);       
                }
            } while (true);
        }

        private static void employeeListExample()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmpDob = DateTime.Now.AddDays(-14244), EmpEmail = "temp@gmail.com", EmpId = 111, EmpName = "David Becham", EmpSalary = 56000 });
            foreach (Employee emp in employees) 
                Console.WriteLine(emp.EmpName + " was born on " + emp.EmpDob + " is now aged " + (DateTime.Now.Year - emp.EmpDob.Year));
        }

        private static void listExample()
        {
            List<string> fruits = new List<string>();//0 Size
            fruits.Add("Apples");//Adds to the bottom of the List. 
            fruits.Add("Mangoes");
            fruits.Add("Oranges");
            fruits.Add("Pine Apples");
            fruits.Add("Gauvas");
            fruits.Add("Dark Grapes");
            fruits.Add("Green Grapes");
            fruits.Insert(3, "Bananas");
            fruits.InsertRange(6, new string[] { "Kiwi Fruit", "Strawberry", "Papaya" });
            Console.WriteLine("The Total no: " + fruits.Count);
            Console.WriteLine("Iterating using foreach loop:");
            foreach (string fruit in fruits) Console.WriteLine(fruit);
            Console.WriteLine("Iterating using for loop:");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
