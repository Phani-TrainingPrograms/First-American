using System;
using System.IO;
namespace SampleConApp
{
    //A UDT Created to represent a real world Patient of a Hospital Management Software. 
    class Patient
    {
         int PatientId;
         string PatientName;
         long PatientPhoneNo;
         string PatientAddress;

        //Functions are created to manipulate the hidden data of UR class. Usually functions are public. 

        public string GetName()
        {
            return PatientName;
        }
        public void SetName(string value)
        {
            PatientName = value;
        }

        public void SetAddress(string value)
        {
            PatientAddress = value;
        }

        public void SetContact(long phone)
        {
            PatientPhoneNo = phone;
        }
        public void SetId(int no)
        {
            PatientId = no;
        }

       
    }

    class Ex09ClassesAndObjects
    {
        static void Main()
        {
            int id = UIConsole.GetNumber("Enter an ID");
            string name = UIConsole.GetString("Enter the Name");
            string address = UIConsole.GetString("Enter the Address");
            long phoneNo = UIConsole.GetLong("Enter the contactNo");

            Patient patient = new Patient();//instantiate an object of a class. U R creating a Variable of the class so that U can use it. 
            patient.SetId(id);
            patient.SetName(name);
            patient.SetContact(phoneNo);
            patient.SetAddress(address);

            Console.WriteLine("The Name of the patient is " + patient.GetName());
        }
    }
}
