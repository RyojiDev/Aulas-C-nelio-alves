using System;
using System.Globalization;
using CourseExercicioPolimorfismoFix.Entities;
using System.Collections.Generic;

namespace CourseExercicioPolimorfismoFix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common,used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(option == 'c' || option == 'C')
                {
                    list.Add(new Product(name,price));
                    
                }else if(option == 'u' || option == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name,price,manufacture));
                }
                else
                {
                    Console.Write(" Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsfee));
                }

            }

            Console.WriteLine("PRICE TAGS: ");

            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

            
        }
    }
}
