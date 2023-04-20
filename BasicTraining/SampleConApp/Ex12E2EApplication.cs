using System;
using System.IO;
namespace SampleConApp
{
    //Entites are class that represent real world objects.
    namespace Entities
    {
        class Expense
        {
            public int ExpenseId { get; set; }
            public string Details { get; set; }
            public DateTime ExpenseDate { get; set; }
            public int Amount { get; set; }
        }
    }

    namespace DataLayer
    {
        //A class to perform the data centric operations: Adding, removing, updating and finding. 
        using Entities;
        class ExpenseManager
        {
            const int size = 100;
            //Data is private...
            private Expense[] expenses = new Expense[size];
            public void AddNewExpense(Expense expense)
            {
                //Iterate the collection
                for (int i = 0; i < size; i++)
                {
                //Find the first location where the value is null
                if(expenses[i] == null)
                    {
                        expenses[i] = new Expense
                        {
                            Amount = expense.Amount,//Set the values to that location
                            Details = expense.Details,
                            ExpenseDate = expense.ExpenseDate,
                            ExpenseId = expense.ExpenseId
                        };
                        return;//exit the function.
                    }
                }
            }

            public void DeleteExpense(int id)
            {

            }
            //Id is not modified, other details could be modified
            public void UpdateExpense(Expense expense)
            {
                //Iterate thru the collection
                for (int i = 0; i < size; i++)
                {
                    if (expenses[i] != null && expenses[i].ExpenseId == expense.ExpenseId)//Find the matching Expense based on Id
                    {
                        expenses[i].Amount = expense.Amount;
                        expenses[i].Details = expense.Details;
                        expenses[i].ExpenseDate = expense.ExpenseDate;
                        expenses[i].ExpenseId = expense.ExpenseId;
                        //Provide the new values
                        //Exit the function....
                        return;
                    }
                }
               
            }

            public Expense[] GetAllExpenses(string detail)
            {
                //First iterate thro the collection to find the matching data and get the no of matching data.
                int count = 0;
                foreach (Expense item in expenses)
                {
                    if(item != null && item.Details.Contains(detail))
                    {
                        count++;
                    }
                }

                //Create an Array of that size and fill the data and return it. 
                if (count != 0)
                {
                    int tempIndex = 0;//For storing local index
                    Expense[] foundExpenses = new Expense[count];
                    foreach (Expense item in expenses)
                    {
                        if (item != null && item.Details.Contains(detail))
                        {
                            foundExpenses[tempIndex] = item;
                            tempIndex++;
                        }
                    }
                    return foundExpenses;
                }
                else
                    return null;
            }
        }
    }


    namespace UILayer
    {
        using DataLayer;
        using Entities;
        class Ex12E2EApplication
        {
            #region Data
            const string filePath = @"C:\Trainings\FAI-April2023\BasicTraining\SampleConApp\Menu.txt";
            static ExpenseManager manager = new ExpenseManager();
            #endregion

            static string getMenu()
            {
                return File.ReadAllText(filePath);
            }
            static void clearScreen()
            {
                Console.WriteLine("Press any key to clear");
                Console.ReadKey();
                Console.Clear();
            }
            static void Main(string[] args)
            {
                string menu = getMenu();
                bool processing = true;
                do
                {
                    string choice = UIConsole.GetString(menu);
                    processing = processMenu(choice);
                    clearScreen();
                } while (processing);
            }

            static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "N":
                        addingExpenseHelper();
                        return true;
                    case "U":
                        updatingExpenseHelper();
                        return true;
                    case "F":
                        findingExpenseHelper();
                        return true;
                    case "D":
                        return true;
                    default: 
                        return false;
                }
            }

            private static void updatingExpenseHelper()
            {
                //Create the Expense object
                Expense expenseObj = new Expense();
                //Take inputs from the user for the expense
                expenseObj.ExpenseId = UIConsole.GetNumber("Enter the ExpenseId for updating");
                expenseObj.Details = UIConsole.GetString("Enter the Details of the Expense in a Short manner for updating");
                expenseObj.ExpenseDate = UIConsole.GetDate("Enter the Date of the Expense for updating");
                expenseObj.Amount = UIConsole.GetNumber("Enter the Amount of Expense for updating");
                //Call the AddExpense method of the manager
                manager.UpdateExpense(expenseObj);
                //Display Success Message
                UIConsole.PrintMessage("Expense Updated Successfully");
            }

            private static void findingExpenseHelper()
            {
                string finder = UIConsole.GetString("Enter the Expense Detail or a part of the detail to find");
                Expense[] expenses = manager.GetAllExpenses(finder);
                if(expenses != null)
                {
                    foreach(Expense expense in expenses)
                    {
                         Console.WriteLine($"{expense.Details} spent on {expense.ExpenseDate} spent an amount of {expense.Amount}");
                    }
                }else
                {
                    Console.WriteLine("No expense found matching the criteria");
                }
            }

            
            private static void addingExpenseHelper()
            {
                //Create the Expense object
                Expense expenseObj = new Expense();
                //Take inputs from the user for the expense
                expenseObj.ExpenseId = UIConsole.GetNumber("Enter the ExpenseId");
                expenseObj.Details = UIConsole.GetString("Enter the Details of the Expense in a Short manner");
                expenseObj.ExpenseDate = UIConsole.GetDate("Enter the Date of the Expense");
                expenseObj.Amount = UIConsole.GetNumber("Enter the Amount of Expense");
                //Call the AddExpense method of the manager
                manager.AddNewExpense(expenseObj);
                //Display Success Message
                UIConsole.PrintMessage("Expense Added Successfully");
            }
        }

    }
}
