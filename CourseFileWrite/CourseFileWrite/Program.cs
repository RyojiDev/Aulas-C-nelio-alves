using System;
using System.IO;

namespace CourseFileWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Ryoji FitBank\Documents\teste.txt";
            string targetPath = @"C:\Users\Ryoji FitBank\Documents\teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("An error ocurred in program " + e.Message);
            }
        }
    }
}
