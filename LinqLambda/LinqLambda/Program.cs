using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using LinqLambda.Entities;

namespace LinqLambda
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
                
            }
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1,"Tools",2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Electronics", 1);

            List<Product> products = new List<Product>() {
                new Product(1,"Computer",1100.0,c2),
                new Product(2, "Hammer", 90.0, c1),
                new Product(3,"TV",1700.0,c3),
                new Product(4,"Notebook",1300.0,c2),
                new Product(5,"Saw",80.0,c1),
                new Product(6,"Tablet",700.0,c2),
                new Product(7,"Camera",700.0,c3),
                new Product(8,"Printer",350.0,c3),
                new Product(9,"MacBook",1800.0,c2),
                new Product(10,"Sound Bar",700.0,c3),
                new Product(11,"Level",70.0,c1)
            };



            // var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.0
                     select p;

            Print("Tier 1 AND PRICE < 900: ", r1);

            Console.WriteLine();
            //var r2 = products.Where(p => p.Category.Name == "Tools" ).Select(p => p.Name);

            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Name of products from tools: ", r2);
            Console.WriteLine();


            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });

            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            Console.WriteLine();
            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;

            Console.WriteLine();
            Print("Tier 1 ORDER BY PRICE THE BY NAME ", r4);

            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            //var r5 = r4.Skip(2).Take(4);

            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();

            Console.WriteLine("First or default test2 " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine(r8);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(products => products.Price);

            Console.WriteLine("AVG : " + r13.ToString("F2",CultureInfo.InvariantCulture));

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty().Average();

            Console.WriteLine("Category 5 average: " + r14);

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);

            Console.WriteLine("Category 1 aggregate " + r15);

            var r16 = products.GroupBy(p => p.Category);

            Console.WriteLine();

            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category" + group.Key.Name);
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine();
            }

        }
    }
}
