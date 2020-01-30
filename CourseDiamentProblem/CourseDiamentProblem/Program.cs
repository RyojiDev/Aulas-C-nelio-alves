using System;
using System.IO;
using System.Collections.Generic;
using CourseDiamentProblem.Devices;
using CourseDiamentProblem.Model.Entititys;

namespace CourseDiamentProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());*/


            /*================= Icomparable =================*/
            string path = @"c:\temp\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list){
                        Console.WriteLine(emp);
                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            /*================= Exercicio =================*/


        }
    }
}
