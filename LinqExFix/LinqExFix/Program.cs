using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using LinqExFix.Entities;

namespace LinqExFix
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

                Console.Write("Enter salary: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                List<Employee> emp = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');

                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2],CultureInfo.InvariantCulture);
                    
                    emp.Add(new Employee(name, email, salary));
                }

                
            }

            double sValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                var emails = emp.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                var sum = emp.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));


                foreach (string e in emails)
            {
                Console.WriteLine(e);

            }

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));


            }
            catch (IOException e)
            {
                Console.WriteLine("Message Error: " + e.Message);
            }
        }
            
    }
}
