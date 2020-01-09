using System;
using CourseHeranca.Entities;

namespace CourseHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00,500.0);

            Console.WriteLine(account.Balance);

            
        }
    }
}
