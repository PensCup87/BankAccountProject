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

        private double CheckingBalance
        {
            get { return this.checkingBalance; }
        }

        public void IntialBalanceCheck()
        {
            this.checkingBalance = 2000d;
            Console.WriteLine("Your current balance is $" + checkingBalance);
        }

        public override void DepositUpdate()
        {
            Console.WriteLine("Current Checking Balance: $" + checkingBalance);
        }

        public void CheckingDepositUpdade()
        {
            checkingBalance = checkingBalance + deposit;
            Console.WriteLine("Your post deposit balance is $" + checkingBalance);
        }

        public void CheckinWithdrawUpdate()
        {
            if (checkingBalance > withdraw)
            {
                checkingBalance = checkingBalance - withdraw;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }
    }
}
