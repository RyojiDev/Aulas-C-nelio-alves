using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHeranca.Entities
{
    class BusinessAccount : Account
    {

        public BusinessAccount()
        {
            Balance = 20;
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) :base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }

        public double LoanLimit { get; set; }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
            
        }
    }
}
