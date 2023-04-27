using System;
using System.IO;
using System.Collections.Generic;
/*
 * Features:
 * Menu Driven Program ---DONE
 * Interface Program---
 * Factory Pattern Implementation
 * File Access, where data is stored in the form of CSV file. 
 * It will handle all Exceptions. 
 */
namespace SampleConApp.Entities
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; } = 10;

        public override string ToString()
        {
            return $"{ProductId},{ProductName},{ProductPrice},{Quantity}\n";
        }
    }
}
namespace SampleConApp.DataLayer
{
    using SampleConApp.Entities;
    interface IProductRepo
    {
        void AddNewProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetAllProducts();
        Product FindProduct(int id);

    }

    class CsvProductRepo : IProductRepo
    {
        const string csvFile = "ProductDatabase.csv";
        private List<Product> products = new List<Product>();
        private void saveData()
        {
            string allData = string.Empty;
            foreach (var product in products)
                allData += product.ToString();
            File.WriteAllText(csvFile, allData);
        }

        private void loadData()
        {
            products.Clear();//Remove old data...
            if (!File.Exists(csvFile))
            {
                products = new List<Product>();
                return;
            }
            var lines = File.ReadAllLines(csvFile);
            foreach (var line in lines)
            {
                var words = line.Split(',');
                Product product = new Product
                {
                    ProductId = Convert.ToInt32(words[0]),
                    ProductName = words[1], 
                    ProductPrice = Convert.ToInt32(words[2]),
                    Quantity =  Convert.ToInt32(words[3])
                };
                products.Add(product);
            }
        }
        public void AddNewProduct(Product product)
        {
            loadData();
            products.Add(product);
            saveData();
        }

        public void DeleteProduct(int id)
        {
            loadData();
            int index = products.FindIndex((p) => p.ProductId == id);
            if(index  < 0)
            {
                throw new Exception("No matching product found");
            }
            products.RemoveAt(index);
            saveData();
        }

        public Product FindProduct(int id)
        {
            loadData();
            var found = products.Find((p) => p.ProductId == id);
            
            if (found == null) throw new Exception("No matching Product found");
            return found;
        }

        public List<Product> GetAllProducts()
        {
            loadData();
            return products;
        }

        public void UpdateProduct(Product product)
        {
            loadData();
            var rec = FindProduct(product.ProductId);
            rec.ProductName = product.ProductName;
            rec.ProductPrice = product.ProductPrice;
            rec.Quantity = product.Quantity;
            saveData();
        }
    }
}
namespace SampleConApp.UILayer
{
    using SampleConApp.Entities;
    using SampleConApp.DataLayer;
    class ProductProgram
    {
        const string menuFile = @"C:\Trainings\FAI-April2023\BasicTraining\SampleConApp\Week2\ProductMenu.txt";
        static readonly string menu = File.ReadAllText(menuFile);
        static void Main(string[] args)
        {
            bool looping = true;
            do
            {
                var choice = UIConsole.GetString(menu);
                looping = processMenu(choice);
                UIConsole.ClearScreen();
            } while (looping);
        }

        private static bool processMenu(string choice)
        {
            switch (choice.ToUpper())
            {
                case "N" : return addingHelper();
                case "F": return findingHelper();
                default:
                    return false;
            }
        }

        private static bool findingHelper()
        {
            try
            {
                //take input from the user as id.
                int id = UIConsole.GetNumber("Enter the Id of the product to find");
                //call the interface Api that finds the record
                var interfaceObj = new CsvProductRepo();
                var rec = interfaceObj.FindProduct(id);
                //display the record
                UIConsole.PrintMessage(rec.ToString());
                //handle the exceptions if any...
            }
            catch (Exception ex)
            {
                UIConsole.PrintError(ex.Message);
            }
            return true;
        }

        private static bool addingHelper()
        {
            //Create the product object. 
            var product = new Product();
            try
            {
                //Take inputs from the user for id, name, price
                product.ProductId = UIConsole.GetNumber("Enter the Product Id");
                product.ProductName = UIConsole.GetString("Enter the Product Name");
                product.ProductPrice = UIConsole.GetNumber("Enter the Cost of the Product");
                //Create the instance of the ProductRepo and call the Adding method
                IProductRepo repo = new CsvProductRepo();
                repo.AddNewProduct(product);
                //Display the success message
                UIConsole.PrintMessage("Product Added successfully");
            }
            catch (Exception ex)
            {
                UIConsole.PrintError(ex.Message);
            }
            return true;
           //handle exception , if exception display the Error message
        }
    }
}