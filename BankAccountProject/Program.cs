using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string userChoice;
            string accountChoice;
            
            do
            {
                Client newClient = new Client();
                Checking newChecking = new Checking();
                Savings newSavings = new Savings();

                //Cold open
                Console.WriteLine("Please select the number from the following options:");
                Console.WriteLine("1 View Client Information");
                Console.WriteLine("2 View Account Balance");
                Console.WriteLine("3 Deposit Funds");
                Console.WriteLine("4 Withdraw Funds");
                Console.WriteLine("5 Exit");

                userChoice = Console.ReadLine().Trim();
                if (userChoice == "1")
                {
                    newClient.GetCustomerInfo();
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("A Checking");
                    Console.WriteLine("B Savings");
                    accountChoice = Console.ReadLine().ToLower();
                    if(accountChoice == "a")
                    {
                        //Check Balance Checking Account
                        newChecking.IntialBalanceCheck();
                    }
                    else
                    {
                        //check Balance Savings Account
                        newSavings.InitialSavingsCheck();
                    }
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("A Checking");
                    Console.WriteLine("B Savings");
                    accountChoice = Console.ReadLine().ToLower();
                    if (accountChoice == "a")
                    {
                        //deposit checking funds
                        newChecking.DepositUpdate();
                    }
                    else
                    {
                        //deposit saving funds
                        newSavings.DepositUpdate();
                    }
                }
                else if (userChoice == "4")
                {

                }

            }
            while (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4");
            if(userChoice == "5")
            {
                Console.WriteLine("Thank you for banking today");
            }
        }
    }
}
