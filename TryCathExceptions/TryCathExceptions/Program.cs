using System;


namespace TryCathExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.Write("numero 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("numero 2: ");
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;

            Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finnaly");
            }
        }
    }
}
