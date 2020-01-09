using System;


namespace CourseUppDown.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance,double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }
    }
}
