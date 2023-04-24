using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Week2
{
    class LoginManager
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        public static bool SignIn(string username, string password)
        {
            if (!users.ContainsKey(username))
            {
                throw new Exception("User name is invalid");
            }
            else
            {
                if (users[username] != password)
                    throw new Exception("Password is incorrect");
                return true;
            }
        }

        public static bool SignUp(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                throw new Exception("Username is already taken!!!!");
            }
            else
            {
                users.Add(username, password);
                return true;
            }
        }
    }
    class Ex02LoginDictionaryExample
    {
        const string menu = "Login Page\nTo Sign In----->Press 1\nTo Sign Up----->Press 2\n";
        static void Main(string[] args)
        {
            bool processing = false;
            do
            {
                int choice = UIConsole.GetNumber(menu);
                processing = processChoice(choice);                
            } while (processing);
        }

        private static bool processChoice(int choice)
        {
            if(choice == 1)
            {
                string username = UIConsole.GetString("Enter the Username");
                string password = UIConsole.GetString("Enter the Password");
                try
                {
                    if(LoginManager.SignIn(username, password))
                        Console.WriteLine("Welcome to the User: " + username);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return true;
            }
            else if(choice == 2){
                string username = UIConsole.GetString("Enter the Username for Registration");
                string password = UIConsole.GetString("Enter the Password for the Registration");
                try
                {
                    LoginManager.SignUp(username, password);
                    Console.WriteLine("You have been successfully registered, Please login");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return true;
            }
            return false;
        }
    }
}
