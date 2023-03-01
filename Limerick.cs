/*---------------------------------------------------------------------*/
// Limerick.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/
using System;

namespace   Alvachon.Limerick
{
    class   Limerick
    {
        public static void Main()
        {
            string  strLimerick =
                "There one was a coder named Otto\r\n" +
                "Who had a peculiar motto:\r\n" +
                "   \"The goto is king,\r\n" +
                "   To thee I sing!\"\r\n" +
                "Maybe that's why he's often quite blotto.\r\n";
            Console.WriteLine(strLimerick);
        }
    }
}
