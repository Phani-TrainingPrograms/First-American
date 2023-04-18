using System;

namespace SampleConApp
{
    enum AccountType : byte
    {
        SBAccount, FDAccount, RDAccount
    }
    class Ex04Enums
    {
        static void Main(string[] args)
        {
            //AccountType acc = AccountType.RDAccount;
            //Console.WriteLine("The Account type is " + acc);
            //Console.WriteLine("Its integral value is " + (int)acc);
            //Console.WriteLine("The data type of the Enum is " + acc.GetTypeCode());//Byte. 

            /////////////Taking input from the user/////////
            Console.WriteLine("Enter the Account type from the List below");
            Array possibleValues = Enum.GetValues(typeof(AccountType));
            for(int i=0; i< possibleValues.Length; i++)
            {
                Console.WriteLine(possibleValues.GetValue(i));
            }
            //string input = Console.ReadLine();
            //object selectedType = Enum.Parse(typeof(AccountType), input, true);
            //AccountType selected = (AccountType)selectedType;
            AccountType selected = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine(), true);

            Console.WriteLine("The selected Account type is " + selected);
        }
    }
}
