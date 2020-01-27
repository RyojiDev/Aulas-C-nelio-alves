using System;
using System.IO;

namespace CourseFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string sourcePath = @"C:\Users\Ryoji FitBank\Documents\teste.txt";
             string targetPath = @"C:\Users\Ryoji FitBank\Documents\novo3.txt";

             try
             {
                 FileInfo fileInfo = new FileInfo(sourcePath);
                 fileInfo.CopyTo(targetPath);
                 string[] lines = File.ReadAllLines(sourcePath);
                 foreach(string line in lines)
                 {
                     Console.WriteLine(line);
                 }
             }catch(IOException e)
             {
                 Console.WriteLine("An error occurred");
                 Console.WriteLine(e.Message);
             }*/

            string path = @"C:\Users\Ryoji FitBank\Documents\teste.txt";

            try { 
           
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                } 
            

            }catch(IOException e)
            {
                Console.WriteLine("an error ocurred " + e.Message);
            }
            /*try
            {
                
                sr = File.OpenText(path);
                var count = 1;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(count + "" + line);

                    count++;
                }
               


               
               
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                
                
            }*/
        }
    }
}
