/*---------------------------------------------------------------------*/
// GetTheUserName.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/
using System;

namespace   Alvachon.GetTheUserName
{
    class   GetTheUserName
    {
        static void Main()
        {
            string  strName;

            Console.Write("Type your name and press Enter: ");
            strName = Console.ReadLine();
            Console.Write("Your name is ");
            Console.WriteLine(strName);
        }
    }
}
