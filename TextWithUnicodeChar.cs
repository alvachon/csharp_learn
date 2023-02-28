/*---------------------------------------------------------------------*/
// TextWithUnicodeChar.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/

namespace Alvachon.TextWithUnicodeChar
{
    class TextWithUnicodeChar
    {
        public static void Main()
        {
            System.Windows.Forms.MessageBox.Show("Hello, Microsoft\x00AE .NET");
        }
    }
}
