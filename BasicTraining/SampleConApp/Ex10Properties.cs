using System;

namespace SampleConApp
{
    namespace PropertiesExample
    {
        class Patient
        {
            //Private members are declared with camel casing and an optional _ as prefix. 
            int _patientId;
            string _patientName;
            long _patientPhoneNo;
            string _patientAddress;

            //Properties are accessors with get/set blocks within it. They are very user friendly as they are used like fields of a class. 

            public int PatientId
            {
                get { return _patientId; }
                set { _patientId = value; }//value is the smart keyword that represents the value the user wants to set. its data type will be the data type of the property
            }

            public string PatientName
            {
                get { return _patientName; }
                set { _patientName = value; }
            }

            public string PatientAddress
            {
                get { return _patientAddress; }
                set { _patientAddress = value; }
            }

            public long PatientPhoneNo
            {
                get { return _patientPhoneNo; }
                set { _patientPhoneNo = value; }
            }
        }
    }
    class Ex10Properties
    {
        static void Main(string[] args)
        {
            PropertiesExample.Patient patient = new PropertiesExample.Patient();
            patient.PatientId = UIConsole.GetNumber("Enter the Id");
            patient.PatientName = UIConsole.GetString("Enter the Name");
            patient.PatientPhoneNo = UIConsole.GetLong("Enter the contact no");
            patient.PatientAddress = UIConsole.GetString("Enter the Address");
        }
    }
}
