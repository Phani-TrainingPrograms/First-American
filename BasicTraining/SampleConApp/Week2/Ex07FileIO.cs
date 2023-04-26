using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SampleConApp.Week2
{
    class Ex07FileIO
    {
        [STAThread]
        static void Main(string[] args)
        {
            //readingTextFile();
            //writingTextFile();
            //appendingTextFile();
            //writeEmployeeToFile();
            //menuDrivenApp();
            //listingFiles("*.pdf");
            copyPdfFiles();
        }

        private static void copyPdfFiles()
        {
            string destDir = "C:\\Trainings\\CopyDir\\";
            string sourceDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var files = Directory.GetFiles(sourceDir, "*.pdf");
            if (!Directory.Exists(destDir))
                Directory.CreateDirectory(destDir);
            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);                
                string newFilepath = Path.Combine(destDir, fileInfo.Name);
                fileInfo.CopyTo(newFilepath, true);
            }
        }

        private static void listingFiles(string filter)
        {
            var contents = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filter);
            foreach(var file in contents)
            {
                FileInfo info = new FileInfo(file);
                Console.WriteLine("The Details of the file are as follows:");
                Console.WriteLine("The Name of the File: " + info.Name);
                Console.WriteLine("The file was created on " + info.CreationTime);
                Console.WriteLine("The file size is " + info.Length + " bytes");
                Console.WriteLine("\n");
            }
        }

        private static void menuDrivenApp()
        {
            string fileName = @"C:\Trainings\FAI-April2023\BasicTraining\SampleConApp\Week2\FileMenu.txt";
            string content = File.ReadAllText(fileName);
            bool looping = true;
            do
            {
                var choice = UIConsole.GetNumber(content);
                looping = processMenu(choice);
            } while (looping);
        }

        private static bool processMenu(int choice)
        {
            if(choice == 1)
            {
                writeEmployeeToFile();
            }
            else if (choice == 2)
            {
                List<Employee> empList = getAllEmployees();
                foreach (var emp in empList)
                {
                    Console.WriteLine(emp.EmpName);
                }
            }
            else
            {
                Console.WriteLine("Exiting the Application");
                return false;
            }
            return true;
        }

        private static List<Employee> getAllEmployees()
        {
            //Create a blank List of Employees...
            List<Employee> list = new List<Employee>();
            //Read each line of the File...
            var lines = File.ReadAllLines("Employees.csv");
            foreach (var line in lines)
            {
                //Split each line into parts
                var parts = line.Split(',');
                //Take each part and fill it into a single Employee object
                var emp = new Employee();
                emp.EmpId = int.Parse(parts[0]);
                emp.EmpName = parts[1];
                emp.EmpEmail = parts[2];
                emp.EmpDob = DateTime.Parse(parts[3]);
                emp.EmpSalary = double.Parse(parts[4]);
                //Add the Employee object to the List created above
                list.Add(emp);
            }
            return list;
            //Finally Return the List
        }

        private static void writeEmployeeToFile()
        {
            Employee emp = new Employee();
            emp.EmpId = 123;
            emp.EmpName = "Phaniraj";
            emp.EmpEmail = "phanirajbn@gmail.com";
            emp.EmpDob = DateTime.Parse("01/12/1976");
            emp.EmpSalary = 45000;
            string content = $"{emp.EmpId},{emp.EmpName},{emp.EmpEmail},{emp.EmpDob},{emp.EmpSalary}\n";
            File.AppendAllText("Employees.csv", content);
            Console.WriteLine("Employee data written to the file");
        }

        private static void appendingTextFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            string fileName = dlg.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("No file selected to Write");
                return;
            }
            Console.WriteLine("Writing to the file: " + fileName);
            Console.WriteLine("Write down the contents of the file and press Enter for Closing");
            string content = Console.ReadLine();
            File.AppendAllText(fileName, content + "\n");
            Console.WriteLine("File appended, Please read it!!!");
        }

        private static void writingTextFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            string fileName = dlg.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("No file selected to Write");
                return;
            }
            Console.WriteLine("Writing to the file: " + fileName);
            Console.WriteLine("Write down the contents of the file and press Enter for Closing");
            string content = Console.ReadLine();
            File.WriteAllText(fileName, content);
            Console.WriteLine("File Written, Please read it!!!");
        }

        private static void readingTextFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            string fileName = dlg.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("No file was selected");
                return;
            }
            string fileContents = File.ReadAllText(fileName);
            Console.WriteLine(fileContents);
            
        }
    }
}
