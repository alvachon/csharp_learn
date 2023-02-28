/*---------------------------------------------------------------------*/
// FirstProgram.cs 2023 by alvachon
// OS: Ubuntu | Text Editor: vim | .NET Framework: Mono
// Tutorial: .NET Book Zero by Charles Petzold
/*---------------------------------------------------------------------*/

class FirstProgram
{
    public static void Main()
    {
        System.Console.WriteLine("Hello, Microsoft .NET Framework!");
    }
}

/*
 * 1. Can change class for struct. The program will run the same.
 * 2. Keyword "public" is not generally required.
 * 3. System is a namespace.
 * 4. Console is a class in that namespace.
 * 5. WriteLine is a method in that class.
 * 6. C# Compiler does not need header files.
 * 7. C# Compiler does not need library files.
 * 8. C# Compiler access directly the DLL via mscorlib.dll by default.
 * 9. For other DLLs, need to add Reference.
 */
