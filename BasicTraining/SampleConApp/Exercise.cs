using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; } = 100;//Default value to the property
    }
    class Exercise
    {

        static Product createProduct(int id, string name, double cost)
        {
            return new Product
            {
                Price = cost, ProductId = id, ProductName = name
            };
        }
        static void Main(string[] args)
        {
            int id = UIConsole.GetNumber("Enter the Id for the product");
            string name = UIConsole.GetString("Enter the Name of the product");
            double price = UIConsole.GetDouble("Enter the Cost of the product");

            Product product = createProduct(id, name, price);
            
            Console.WriteLine($"Product Name: {product.ProductName}\nThe Price: {product.Price}\nThe StockCount: {product.Stock}");
        }
    }
}

//Assignment: Create a menu driven Calculator program that has the following functionalities: Arithematic operations along with Square and SquareRoot.
//The Program should display a Menu for the Application allowing the user to select the choice of the operation, appropriately take inputs and display the result of the Operation.
//The App should be in a proper loop so that the App does not close until the User wishes to close. There should be Menu option to close the Application, and only then the App closes. 


