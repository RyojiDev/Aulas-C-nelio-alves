﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDiamentProblem.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan()
        {
            return "Combodevice scan Result";
        }
    }
}
