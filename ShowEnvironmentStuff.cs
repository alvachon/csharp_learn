/*---------------------------------------------------------------------*/
// ShowEnvironmentStuff.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/
using System;

namespace   Alvachon.ShowEnvironmentStuff
{
    class   ShowEnvironmentStuff
    {
        static void Main()
        {
            int msec;
            Console.WriteLine("My Documents is actually  " +
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine();
            msec = Environment.TickCount;
            Console.WriteLine("Windows has been running for " +
                    msec + " milliseconds");
            Console.WriteLine("\tor " + msec /3600000.0 + " hour");
            Console.WriteLine();

            Console.WriteLine("You are running " + Environment.Version);
            Console.WriteLine();
        }
    }
}
