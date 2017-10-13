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


            Client newClient = new Client();




                //Cold open
                Console.WriteLine("Please select the number from the following options:");
                Console.WriteLine("1 View Client Information");
                Console.WriteLine("2 View Account Balabce");
                Console.WriteLine("3 Deposit Funds");
                Console.WriteLine("4 Withdraw Funds");
                Console.WriteLine("5 Exit");

            string userChoice = Console.ReadLine().Trim();
            if(userChoice == "1")
            {
                newClient.GetCustomerInfo();
            }
            if(userChoice == "2")
            {

            }
            if(userChoice == "3")
            {

            }
            if(userChoice == "4")
            {

            }


        }
    }
}
