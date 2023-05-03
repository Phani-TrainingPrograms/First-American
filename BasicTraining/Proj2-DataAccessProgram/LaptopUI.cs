using System;
using SampleDataAccessLib;
//Add the reference of the DLL before U try using the namespace in the code
namespace Proj2_DataAccessProgram
{
    class LaptopUI
    {
        static void Main(string[] args)
        {
            ILaptopDB instance = Factory.GetComponent();
            var data =  instance.GetAllLaptops();
            foreach(var item in data)
                Console.WriteLine(item.EmpName);
            try
            {
                //addingFeature();
                updatingFeature();
            }
            catch(Exception ex)
            {
                UIConsole.PrintError(ex.Message);
            }
        }

        private static void updatingFeature()
        {
            //create the LaptopInfo object
            var laptopDetails = new LaptopInfo();
            laptopDetails.EntryId = UIConsole.GetNumber("Enter the ID of the Laptop that U want to update");
            //Fill the values to the properties of the object
            laptopDetails.BrandName = UIConsole.GetString("Enter the New Brand name of the Laptop");
            laptopDetails.Series = UIConsole.GetString("Enter the New Series of the Laptop");
            laptopDetails.EmpName = UIConsole.GetString("Enter the New Name of the Employee to whom the laptop is allocated");
            laptopDetails.Price = UIConsole.GetDouble("Enter the New Price of the Laptop");
            //Get the ILaptopDB Interface object using factory
            var component = Factory.GetComponent();
            //Call the AddDetails func
            component.UpdateLaptop(laptopDetails);
            //Display the success message
            UIConsole.PrintMessage("Laptop Details updated successfully");
            //handle Exceptions if any...
        }

        private static void addingFeature()
        {
            //create the LaptopInfo object
            var laptopDetails = new LaptopInfo();
            //Fill the values to the properties of the object
            laptopDetails.BrandName = UIConsole.GetString("Enter the Brand name of the Laptop");
            laptopDetails.Series = UIConsole.GetString("Enter the Series of the Laptop");
            laptopDetails.EmpName = UIConsole.GetString("Enter the Name of the Employee to whom the laptop is allocated");
            laptopDetails.Price = UIConsole.GetDouble("Enter the Price of the Laptop");
            //Get the ILaptopDB Interface object using factory
            var component = Factory.GetComponent();
            //Call the AddDetails func
            component.AddNewLaptop(laptopDetails);
            //Display the success message
            UIConsole.PrintMessage("Laptop Details added successfully");
            //handle Exceptions if any...
        }
    }
}
