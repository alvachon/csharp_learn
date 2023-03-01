/*
 * $ dotnet new console -o NameProject -f net6.0
 * $ cd NameProject
 * $ vim Program.cs
 * (edit)
 * $ dotnet run
 *  INSTALL CSHARP MAN PAGE
 * sudo apt install mono-csharp-shell
 */
string greeting = "      Hello World!     ";
string aFriend = "string aFriend = Bill";
string anEnemy;
string start;
string end;
string trim = greeting;
string sayHello = "Hello World!";
string songLyrics = "You say goodbye, and I say hello";
var names = new List<string> { "Alex", "Ana", "Felipe"};
Console.WriteLine("\nList\n");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it");
var index = names.IndexOf("Felipe");
if (index != -1)
    Console.WriteLine($"The name {names[index]} is at index {index}");
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
var fibonacciNumbers = new List<int> {1, 1};
while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);
Console.WriteLine("\nSearch\n");
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
Console.WriteLine("\nCaps no Caps Method");
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
Console.WriteLine(" ");
Console.WriteLine("\nReplace Method");
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine("\nTrim Method");
Console.WriteLine($"[{greeting}]");
start = greeting.TrimStart();
Console.WriteLine($"[{start}]");
end = greeting.TrimEnd();
Console.WriteLine($"[{end}]");
trim = trim.Trim();
Console.WriteLine($"[{trim}]");
Console.WriteLine(" ");
anEnemy = "string anEnemy = Lola";
Console.WriteLine(aFriend);
Console.WriteLine(anEnemy);
aFriend = "Maira";
Console.WriteLine("Mod aFriend = " + aFriend);
Console.WriteLine($"String Interpolation : {anEnemy}");
Console.WriteLine(" ");
Console.WriteLine("Experimenting Console.WriteLine(); and Console.Write(); ");
Console.WriteLine(" ");
Console.WriteLine("This phrase contain a newline carriageN");
Console.Write("(1) This one ");
Console.Write("(2) Do not.");
Console.WriteLine("What about ...N");
Console.Write("...Mixing...");
Console.WriteLine("Both?N");
Console.WriteLine(" ");
Console.WriteLine("Does Carriage Return N\n Work ?(WriteLine)N");
Console.Write("Apparently...N\n Yes for both...(Write)N\n");
Console.WriteLine("But it does a weird tab on the next line after");
Console.WriteLine(" ");

