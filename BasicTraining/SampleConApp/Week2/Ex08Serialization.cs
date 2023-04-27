using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SampleConApp.Week2
{
    interface ISerialization
    {
        void SaveData(List<Employee> employees);
        List<Employee> LoadData();
    }

    class SoapSerialization : ISerialization
    {
        const string fileName = "SoapEmployees.xml";
        public List<Employee> LoadData()
        {
            SoapFormatter fm = new SoapFormatter();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var data = fm.Deserialize(fs) as Employee[];
            fs.Close();
            return data.ToList();
        }

        public void SaveData(List<Employee> employees)
        {
            var dataToSerialize = employees.ToArray();//WHAT
            SoapFormatter formatter = new SoapFormatter();//HOW
            FileStream location = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(location, dataToSerialize);
            location.Close();//Stream should be closed for other part of the Application to read it....
            Console.WriteLine("Data is serialized as Soap");
        }
    }
    class BinarySerialization : ISerialization
    {
        const string fileName = "Data.Bin";
        public List<Employee> LoadData()
        {
            BinaryFormatter fm = new BinaryFormatter();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var data = fm.Deserialize(fs) as List<Employee>;
            fs.Close();
            return data;
        }

        public void SaveData(List<Employee> employees)
        {
            var dataToSerialize = employees;//WHAT
            BinaryFormatter formatter = new BinaryFormatter();//HOW
            FileStream location = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(location, dataToSerialize);
            location.Close();//Stream should be closed for other part of the Application to read it....

        }
    }

    class XmlSerialization : ISerialization
    {
        const string fileName = "Employees.xml";
        public List<Employee> LoadData()
        {
            //Get the serializer
            XmlSerializer fm = new XmlSerializer(typeof(List<Employee>));
            //Get the location
            var loc = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            //Deserialize the data
            var data = fm.Deserialize(loc) as List<Employee>;
            //return it as Unboxed Data
            return data;
        }

        public void SaveData(List<Employee> employees)
        {
            var dataToSerialize = employees; //What
            XmlSerializer fm = new XmlSerializer(typeof(List<Employee>));//How
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);//Where
            fm.Serialize(fs, dataToSerialize);
            fs.Close();
            Console.WriteLine("Data is serialized as Xml");
        }
    }
    enum Format { Binary, Xml, Soap, Json }

    class EmployeeFactory
    {
        public static ISerialization GetObject(Format format)
        {
            switch (format)
            {
                case Format.Binary:
                    return new BinarySerialization();
                case Format.Xml:
                    return new XmlSerialization();
                case Format.Soap:
                    return new SoapSerialization();
                case Format.Json:
                    break;
                default:
                    return null;
            }
            return null;
        }
    }

    class Ex08Serialization
    {
        static void Main(string[] args)
        {
            List<Employee> data = readCSVFile();

            ISerialization component = EmployeeFactory.GetObject(Format.Soap);
            component.SaveData(data);
            //var data = component.LoadData();
            //foreach (var emp in data) 
              //  Console.WriteLine($"{emp.EmpName} - {emp.EmpEmail}");
        }

        private static List<Employee> readCSVFile()
        {
            List<Employee> data = new List<Employee>();
            var lines = File.ReadAllLines("../../Week2/Employees.csv");
            foreach (var line in lines)
            {
                //Split each line into parts
                var parts = line.Split(',');
                //Take each part and fill it into a single Employee object
                var emp = new Employee();
                emp.EmpId = int.Parse(parts[0]);
                emp.EmpName = parts[1];
                emp.EmpEmail = parts[2];
                emp.EmpDob = DateTime.ParseExact(parts[4], "M/d/yyyy", null);
                emp.EmpSalary = double.Parse(parts[3]);
                //Add the Employee object to the List created above
                data.Add(emp);
            }
            return data;
        }
    }
}
