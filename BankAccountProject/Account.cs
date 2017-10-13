using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class Account
    {
        //Some Fields, might not use all
        protected int bankAccountNUmber;
        protected double deposit;
        protected double withdraw;

        //Makeing Properties with blood, sweat, and gears
        public int BankAccountNumber
        {
            get { return this.bankAccountNUmber; }
        }

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }

        //Constrcut Stuff
        public Account()
        {
            //default
        }

        public Account(double deposit, double withdraw)
        {
            this.deposit = deposit;
            this.withdraw = withdraw;

        }

        public virtual void DepositUpdate()
        {
            Console.WriteLine("Your current balance is: $");
        }

        
    }
}
