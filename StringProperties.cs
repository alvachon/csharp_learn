/*---------------------------------------------------------------------*/
// StringProperties.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/
using System;

namespace   Alvachon.StringProperties
{
    class   StringProperties
    {
        static void Main()
        {
            string  strEntered;
            Console.Write("Enter some text: ");
            strEntered = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("The text you entered has " + strEntered.Length + " characters");
            Console.WriteLine("The first character is " + strEntered[0]);
            Console.WriteLine("The last character is " + strEntered[strEntered.Length - 1]);
            Console.WriteLine();
        }
    }
}
