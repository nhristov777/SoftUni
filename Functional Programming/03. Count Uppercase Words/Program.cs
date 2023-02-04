using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            Predicate<string> checker = n => n[0] == n.ToUpper()[0];
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => checker(w))
                .ToArray();
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
