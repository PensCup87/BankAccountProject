using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //fields
        protected string firstName;
        protected string lastName;
        protected int bankAccountNumber;
        


        //Properties

        private string FirstName
        {
            get { return this.firstName; }
        }

        private string LastName
        {
            get { return this.lastName; }
        }

        private int BankAccountNumber
        {
            get { return this.bankAccountNumber; }
            
        }

        
        //Constructor
        public Client()
        {
            //default Const.
            this.firstName = "Harley";
            this.lastName = "Davidson";
            this.bankAccountNumber = 1903;
        }

        public Client(string firstName, string lastName, int bankAccountNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.bankAccountNumber = bankAccountNumber;
            
        }

        //Method Time

        public virtual void GetCustomerInfo()
        {

            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.WriteLine("Your bank account number is: " + bankAccountNumber);
            Console.WriteLine();
        }


    }
}
