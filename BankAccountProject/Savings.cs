﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Account
    {
        //Another Field of dreams
        protected double savingBalance;
        protected double savingDeposit;
        protected double savingWithdraw;

       private double SavingBalance
        {
            get { return this.savingBalance; }
        }

        private double SavingDeposit
        {
            get { return this.savingDeposit; }
            set { this.savingDeposit = value; }
        }

        private double SavingWithdraw
        {
            get { return this.savingWithdraw; }
            set { this.savingWithdraw = value; }
        }

        public Savings()
        {
            this.savingBalance = 1000d;
        }

        public void InitialSavingsCheck()
        {
            Console.WriteLine("Your current balance is $" + savingBalance);
        }

        public override void DepositUpdate()
        {
            Console.WriteLine("Enter your deposit: ");
            savingDeposit = double.Parse(Console.ReadLine());
            savingBalance = savingBalance + savingDeposit;
            Console.WriteLine("Current Checking Balance: $" + savingBalance);
        }


        public void CheckingDepositUpdade()
        {
            savingBalance = savingBalance + deposit;
            Console.WriteLine("Your post deposit balance is $" + savingBalance);
            
        }

        public void CheckinWithdrawUpdate()
        {
            Console.WriteLine("Enter your withdraw: ");
            savingWithdraw = double.Parse(Console.ReadLine());

            if (savingBalance > savingWithdraw && savingBalance > 100)
            {
                savingBalance = savingBalance - savingWithdraw;
                Console.WriteLine("Current Savinging Balance: $" + savingBalance);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }
    }
}
