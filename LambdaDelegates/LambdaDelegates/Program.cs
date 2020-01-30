using System;
using System.Linq;
using System.Collections.Generic;
using LambdaDelegates.Entities;
using LambdaDelegates.Services;

namespace LambdaDelegates
{
    /*delegate double BinaryNumericOperaction(double n1, double n2);*/
    class Program
    {
        static void Main(string[] args)
        {/*
            double a = 10;
            double b = 12;

            BinaryNumericOperaction op = CalculationService.Sum;

            double result = op(a,b);
            Console.WriteLine(result);*/

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("Hd Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();
            List<string> result = list.Select(func).ToList();
            Action<Product> act = UpdatePrice;

            list.ForEach(act);

            foreach (Product p in list)
            {
                
                Console.WriteLine(p);
            }

          
        }

            static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }

        
    }
}
