using System;
using System.IO;
using System.Collections.Generic;

namespace CourseDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ryoji FitBank\Documents\myfolder";
            try
            {
               IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach(string s in folder)
                {
                    Console.WriteLine(s);
                }


                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch(Exception e)
            {
                Console.WriteLine("An erro ocurred " + e.Message);
            }
        }
    }
}
