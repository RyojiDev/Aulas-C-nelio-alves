using System;



namespace CourseDiamentProblem.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing " + document );
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
