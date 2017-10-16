using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account
    {
        //Is it a Field or Instance Variable or Both?
        protected double checkingBalance;
        protected double checkingIncrease;
        protected double checkDecrease;

        private double CheckingBalance
        {
            get { return this.checkingBalance; }
        }

        private double CheckingIncrease
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }

        private double CheckDecrease
        {
            get { return this.checkDecrease; }
            set { this.checkDecrease = value; }
        }

        public Checking()
        {
            this.checkingBalance = 2000d;
        }

        public void IntialBalanceCheck()
        {
            Console.WriteLine("Your current balance is $" + checkingBalance);
        }

        public override void DepositUpdate()
        {
            Console.WriteLine("Enter your deposit: ");
            checkingIncrease = double.Parse(Console.ReadLine());
            checkingBalance = checkingBalance + checkingIncrease;
            Console.WriteLine("Current Checking Balance: $" + checkingBalance);
        }

            public void CheckingWithdrawUpdate()
        {
            Console.WriteLine("Enter your withdraw: ");
            checkDecrease = double.Parse(Console.ReadLine());

            if (checkingBalance > checkDecrease)
            {
                checkingBalance = checkingBalance - checkDecrease;
                Console.WriteLine("Current Checking Balance: $" + checkingBalance);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }
    }
}
