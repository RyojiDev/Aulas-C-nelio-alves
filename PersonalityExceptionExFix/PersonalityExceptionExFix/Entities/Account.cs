using System;
using System.Globalization;
using PersonalityExceptionExFix.Entities.Exception;

namespace PersonalityExceptionExFix.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            else if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return "New Balance:"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
