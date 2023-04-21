using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    enum PaymentMode
    {
        Cash, Cheque, Card
    }
    class FatherBusiness
    {
        protected int _balance = 2000;
        public virtual void RecievePayment(PaymentMode mode, int amount)
        {
            if(mode == PaymentMode.Cash || mode == PaymentMode.Cheque)
            {
                _balance += amount;
                Console.WriteLine($"An Amount of Rs. {amount} has been accepted in the form of {mode}\nThe current Balance is {_balance}");
            }
            else
            {
                Console.WriteLine("Cards are not accepted by us!!!");
            }
        }
    }

    class ChildBusiness : FatherBusiness
    {
        public override void RecievePayment(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cash || mode == PaymentMode.Card)
            {
                _balance += amount;
                Console.WriteLine($"An Amount of Rs. {amount} has been accepted in the form of {mode}\nThe current Balance is {_balance}");
            }
            else
            {
                Console.WriteLine("Cheques are not accepted by us!!!");
            }
        }
    }

    class BusinessFactory
    {
        public static FatherBusiness CreateBusiness(string businessType)
        {
            if (businessType == "Father")
                return new FatherBusiness();
            else
                return new ChildBusiness();
        }
    }
    class Ex14MethodOverriding
    {
        static void Main(string[] args)
        {
            string input = UIConsole.GetString("Enter the Type of Business: Father or Child");
            FatherBusiness pawnBroker = BusinessFactory.CreateBusiness(input);
            pawnBroker.RecievePayment(PaymentMode.Cheque, 3400);
            //As the function behavior is dependent on the input we give at the execution time, we call this as RUNTIME POLYMORPHISM.....

//            pawnBroker = new ChildBusiness();
  //          pawnBroker.RecievePayment(PaymentMode.Card, 5000); //The function will behave differently with the same object. This is called Polymorphism. This is a sp polymorphism called RUNTIME POLYMORPHISM. 
        }
    }
}
