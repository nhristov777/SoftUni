using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            Action<string[]> action = n => Console.WriteLine(string.Join("\n", n));
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            action(names);
        }
    }
}
