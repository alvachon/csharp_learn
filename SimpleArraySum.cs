/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
// simpleArray.cs 2023 by alvachon
// OS : Windows 11 (WSL) | Editor : Visual Studio | .NET Framework: Mono
// Reverse Engineering of simple-array-sum that come from Hackerrank.com
// NEXT PROJECT : Add system Benchmark from CodeMazeBlog:
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;//List
using System.Linq;//.Sum();

/* * * * * * * * * * *
 * 1 + 2 + 3 + 4 + 5
 * Size: 5
 * Sum: 15
 * * * * * * * * * * */

namespace AlVachon.simpleArray
{
    class Result
    {
        public static int simpleArray(List<int> ar)
        {
            //.NET 3.5
            /*
            int sum = ar.Sum();
            return (sum);
            */
            //LINQ ---> Slowest version
            /*
            var sum = ar.Aggregate((temp, x) => temp+x);
            return (sum);
            */
            //Foreach Loop --> Fastest Version
            var result = 0;
            foreach (var item in ar)
                result += item;
            return (result);
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            List<int> array;
            int result;
            int i;

            array = new List<int>();
            i = 0;
            while (i < 4)
            {
                array.Add(i + 1);
                Console.Write(array[i] + " + ");
                i++;
            }
            array.Add(i + 1);
            Console.Write(array[i] + "\n");
            Console.WriteLine("Size: " + array.Count);
            result = Result.simpleArray(array);
            Console.WriteLine("Sum: " + result);
        }
    }
}