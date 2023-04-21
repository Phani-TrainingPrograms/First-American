using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    abstract class Account
    {
        public int AccountNo { get; set; }
        public string HolderName { get; set; }
        public int Balance { get; private set; }

        public void CreditAmount(int amount) => Balance += amount;

        public void DebitAmount(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }

        public abstract void CalculateInterest();
        
    }

    class SBAccount : Account
    {
        //SI = PTR/100
        public override void CalculateInterest()
        {
            int pricipal = Balance;
            double term = 0.25;
            double rateOfInterest = 6.5 / 100;
            double interestAmount = pricipal * term * rateOfInterest;
            CreditAmount((int)interestAmount);
        }
    }

    //TODO: Implement few more account types: FD Account and RD Account. Find out a way of calculating Compound interest for FD Account, RD Interest for RD Account.
    //
    class AccountFactory
    {
        public static Account CreateAccount(string type)
        {
            return new SBAccount();
        }
    }
    class Ex15AbstractClasses
    {
        static void Main(string[] args)
        {
            Account acc = AccountFactory.CreateAccount("");
            acc.AccountNo = 23432432;
            acc.CreditAmount(45000);
            acc.HolderName = "Phaniraj";
            acc.CalculateInterest();
            Console.WriteLine("The current balance is " + acc.Balance);
        }
    }
}
