/*---------------------------------------------------------------------*/
// Verbatim.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/
using C = System.Console;

namespace	Alvachon.Verbatim
{
	class	Verbatim
	{
		public static void Main()
		{
			C.WriteLine("\\Documents and Settings\\Alvachon\\Favorites");
            C.WriteLine(@"\Documents and Settings\Charles\Favorites");
        }
    }
}
			
