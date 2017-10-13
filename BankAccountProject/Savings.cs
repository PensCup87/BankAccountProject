using System;
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

        private double SavingBalance
        {
            get { return this.savingBalance; }
        }

        public void InitialSavingsCheck()
        {
            this.savingBalance = 1000d;
            Console.WriteLine("Your current balance is $" + savingBalance);
        }

        public void CheckingDepositUpdade()
        {
            savingBalance = savingBalance + deposit;
            Console.WriteLine("Your post deposit balance is $" + savingBalance);
        }

        public void CheckinWithdrawUpdate()
        {
            if (savingBalance > withdraw)
            {
                savingBalance = savingBalance - withdraw;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }
    }
}
