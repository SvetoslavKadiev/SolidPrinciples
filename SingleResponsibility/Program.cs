using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace SingleResponsibility
{

    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");
            WriteLine(j);

            var p = new Persistence();
            var filename = @"journal.txt";
            p.SaveToFile(j, filename);
            Process.Start(filename);

            ReadLine();
        }
    }
}
