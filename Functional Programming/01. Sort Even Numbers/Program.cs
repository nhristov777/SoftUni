using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}

